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
                string fetchCategoriesQuery = "SELECT c.Category_ID as ID, c.Category_Name as Name, ISNULL(SUM(i.Item_InStock), 0) as [In-Stock], ISNULL(COUNT(i.Item_ID), 0) as Products " +
                              "FROM tbl_Categories c " +
                              "LEFT JOIN tbl_Items i ON c.Category_ID = i.Category_ID " +
                              "GROUP BY c.Category_ID, c.Category_Name";

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

            if (dgv_Categories.SelectedRows.Count > 0)
            {
                btn_Remove.Enabled = true;

                // Check if any selected row has Products count greater than 0
                foreach (DataGridViewRow selectedRow in dgv_Categories.SelectedRows)
                {
                    int productsCount = Convert.ToInt32(selectedRow.Cells["Products"].Value);
                    if (productsCount > 0)
                    {
                        btn_Remove.Enabled = false;
                        break; // No need to check further if one row has Products count greater than 0
                    }
                }
            }
            else
            {
                btn_Remove.Enabled = false;
            }
        }

        private void FilterCategories(string searchText)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT c.Category_ID as ID, c.Category_Name as Name, ISNULL(SUM(i.Item_InStock), 0) as [In-Stock], ISNULL(COUNT(i.Item_ID), 0) as Products " +
                              "FROM tbl_Categories c " +
                              "LEFT JOIN tbl_Items i ON c.Category_ID = i.Category_ID " +
                              "WHERE c.Category_Name LIKE @SearchText " +
                              "GROUP BY c.Category_ID, c.Category_Name";

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
                    using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dgv_Categories.SelectedRows)
                        {
                            int categoryID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                            string removeCategoryQuery = "DELETE FROM tbl_Categories WHERE Category_ID = @CategoryID";
                            using (SqlCommand removeCategoryCommand = new SqlCommand(removeCategoryQuery, connection))
                            {
                                removeCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                                removeCategoryCommand.ExecuteNonQuery();
                            }
                        }

                        UpdateCategoryInStock(connection);
                        UpdateCategoryProductsCount(connection);

                        RefreshData();
                    }
                }
            }
        }

        public void RefreshData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT c.Category_ID as ID, c.Category_Name as Name, ISNULL(SUM(i.Item_InStock), 0) as [In-Stock], ISNULL(COUNT(i.Item_ID), 0) as Products " +
                                              "FROM tbl_Categories c " +
                                              "LEFT JOIN tbl_Items i ON c.Category_ID = i.Category_ID " +
                                              "GROUP BY c.Category_ID, c.Category_Name";

                SqlCommand fetchCommand = new(fetchCategoriesQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Categories = new();
                adapter.Fill(dt_Categories);
                dgv_Categories.DataSource = dt_Categories;

                UpdateCategoryProductsCount(connection);
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

        public static void UpdateCategoryInStock(SqlConnection connection)
        {
            string updateCategoryInStockQuery = @"
                UPDATE tbl_Categories 
                SET InStock = (
                    SELECT SUM(Item_InStock) 
                    FROM tbl_Items 
                    WHERE tbl_Items.Category_ID = tbl_Categories.Category_ID)";

            using SqlCommand updateCommand = new(updateCategoryInStockQuery, connection);
            updateCommand.ExecuteNonQuery();
        }

        public static void UpdateCategoryProductsCount(SqlConnection connection)
        {
            string updateCategoryProductsCountQuery = @"
            UPDATE tbl_Categories 
            SET Products_Count = (
                SELECT COUNT(Item_ID) 
                FROM tbl_Items 
                WHERE tbl_Items.Category_ID = tbl_Categories.Category_ID)";

            using SqlCommand updateCommand = new(updateCategoryProductsCountQuery, connection);
            updateCommand.ExecuteNonQuery();
        }
    }
}
