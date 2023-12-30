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
            LoadCategories();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using CategoryDetail categoryDetailForm = new();
            categoryDetailForm.CategoryId = 0;
            categoryDetailForm.RefreshCategoriesList = LoadCategories;
            categoryDetailForm.ShowDialog();
        }

        public void LoadCategories()
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

            connection.Close();

            foreach (Form form in Application.OpenForms)
            {
                if (form is CategoryDetail categoryDetail)
                {
                    categoryDetail.RefreshCategoriesList?.Invoke();
                    break;
                }
            }
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

            connection.Close();
        }
    }
}
