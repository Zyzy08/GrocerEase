using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            dgv_Categories.DefaultCellStyle.Font = new Font("Comforta", 10, FontStyle.Regular);
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            dgv_Categories.SelectionChanged += Dgv_Categories_SelectionChanged;
            tb_Search.TextChanged += Tb_Search_TextChanged;

            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT Category_ID as ID, Category_Name as Name, ISNULL(InStock, 0) as [In-Stock] FROM tbl_Categories";
                SqlCommand fetchCommand = new(fetchCategoriesQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Categories = new();
                adapter.Fill(dt_Categories);
                dgv_Categories.DataSource = dt_Categories;
            }
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            FilterCategories(tb_Search.Text);
        }

        private void Dgv_Categories_SelectionChanged(object sender, EventArgs e)
        {
            btn_Edit.Enabled = dgv_Categories.SelectedRows.Count == 1;

            if (dgv_Categories.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Categories.SelectedRows[0].Index;
                int inStock = Convert.ToInt32(dgv_Categories.Rows[selectedRowIndex].Cells["In-Stock"].Value);

                btn_Edit.Enabled = true;

                btn_Remove.Enabled = (inStock == 0);
            }
            else
            {
                btn_Edit.Enabled = false;
                btn_Remove.Enabled = false;
            }
        }

        private void FilterCategories(string searchText)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT Category_ID as ID, Category_Name as Name, ISNULL(InStock, 0) as [In-Stock] FROM tbl_Categories WHERE Category_Name LIKE @SearchText";

                SqlCommand fetchCommand = new(fetchCategoriesQuery, connection);
                fetchCommand.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Categories = new();
                adapter.Fill(dt_Categories);
                dgv_Categories.DataSource = dt_Categories;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            using CategoryDetail categoryDetail = new();
            categoryDetail.Mode = "Add";
            categoryDetail.lbl_ID.Text = CategoryDetail.GetNextCategoryId(connection).ToString();
            categoryDetail.Owner = this.ParentForm;
            categoryDetail.ShowDialog();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Categories.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected category/categories?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new(DatabaseManager.ConnectionString);
                    connection.Open();

                    foreach (DataGridViewRow selectedRow in dgv_Categories.SelectedRows)
                    {
                        int categoryID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        string removeCategoryQuery = "DELETE FROM tbl_Categories WHERE Category_ID = @CategoryID";
                        using SqlCommand removeCategoryCommand = new(removeCategoryQuery, connection);
                        removeCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                        removeCategoryCommand.ExecuteNonQuery();
                    }

                    RefreshData();
                }
            }
        }

        public void RefreshData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT Category_ID as ID, Category_Name as Name, ISNULL(InStock, 0) as [In-Stock] FROM tbl_Categories";

                SqlCommand fetchCommand = new(fetchCategoriesQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Categories = new();
                adapter.Fill(dt_Categories);
                dgv_Categories.DataSource = dt_Categories;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Categories.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Categories.SelectedRows[0].Index;
                int categoryId = Convert.ToInt32(dgv_Categories.Rows[selectedRowIndex].Cells["ID"].Value);

                using SqlConnection connection = new(DatabaseManager.ConnectionString);
                connection.Open();

                using CategoryDetail categoryDetailForm = new();
                categoryDetailForm.Mode = "Edit";
                categoryDetailForm.CategoryId = categoryId;
                categoryDetailForm.Owner = this.ParentForm;
                categoryDetailForm.ShowDialog();

                RefreshData();
            }   
        }
    }
}
