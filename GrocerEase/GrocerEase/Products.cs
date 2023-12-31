﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            dgv_Items.DefaultCellStyle.Font = new Font("Comforta", 10, FontStyle.Regular);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dgv_Items.SelectionChanged += Dgv_Items_SelectionChanged;
            tb_Search.TextChanged += Tb_Search_TextChanged;

            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string fetchItemsQuery = "SELECT i.Item_ID as ID, c.Category_Name as Category, " +
                                     "i.Item_Name as Name, i.Item_NetWT as NetWT, " +
                                     "i.Item_Price as Price, i.Item_InStock as [In-Stock] " +
                                     "FROM tbl_Items i " +
                                     "INNER JOIN tbl_Categories c ON i.Category_ID = c.Category_ID";
                SqlCommand fetchCommand = new(fetchItemsQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Items = new();
                adapter.Fill(dt_Items);
                dgv_Items.DataSource = dt_Items;

                btn_Add.Enabled = CategoriesExist();
            }
        }

        private static bool CategoriesExist()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            string checkCategoriesQuery = "SELECT COUNT(*) FROM tbl_Categories";
            using SqlCommand checkCommand = new(checkCategoriesQuery, connection);
            int categoryCount = (int)checkCommand.ExecuteScalar();
            return categoryCount > 0;
        }

        public void RefreshData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string fetchItemsQuery = "SELECT i.Item_ID as ID, c.Category_Name as Category, " +
                                     "i.Item_Name as Name, i.Item_NetWT as NetWT, " +
                                     "i.Item_Price as Price, i.Item_InStock as [In-Stock] " +
                                     "FROM tbl_Items i " +
                                     "INNER JOIN tbl_Categories c ON i.Category_ID = c.Category_ID";
                SqlCommand fetchCommand = new(fetchItemsQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Items = new();
                adapter.Fill(dt_Items);
                dgv_Items.DataSource = dt_Items;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            using ProductDetail productDetail = new();
            productDetail.Mode = "Add";
            productDetail.lbl_ID.Text = ProductDetail.GetNextItemId(connection).ToString();
            productDetail.Owner = this.ParentForm;
            productDetail.ShowDialog();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Items.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Items.SelectedRows[0].Index;
                int itemId = Convert.ToInt32(dgv_Items.Rows[selectedRowIndex].Cells["ID"].Value);

                using SqlConnection connection = new(DatabaseManager.ConnectionString);
                connection.Open();

                using ProductDetail productDetailForm = new();
                productDetailForm.Mode = "Edit";
                productDetailForm.ItemId = itemId;
                productDetailForm.Owner = this.ParentForm;
                productDetailForm.ShowDialog();

                RefreshData();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Items.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new(DatabaseManager.ConnectionString);
                    connection.Open();

                    foreach (DataGridViewRow selectedRow in dgv_Items.SelectedRows)
                    {
                        int itemID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        string removeItemQuery = "DELETE FROM tbl_Items WHERE Item_ID = @ItemID";
                        using SqlCommand removeItemCommand = new(removeItemQuery, connection);
                        removeItemCommand.Parameters.AddWithValue("@ItemID", itemID);
                        removeItemCommand.ExecuteNonQuery();
                    }

                    RefreshData();
                }
            }
        }

        private void Dgv_Items_SelectionChanged(object sender, EventArgs e)
        {
            btn_Edit.Enabled = dgv_Items.SelectedRows.Count == 1;

            if (dgv_Items.SelectedRows.Count > 0)
            {
                btn_Remove.Enabled = true;

                foreach (DataGridViewRow selectedRow in dgv_Items.SelectedRows)
                {
                    int inStock = Convert.ToInt32(selectedRow.Cells["In-Stock"].Value);
                    if (inStock != 0)
                    {
                        btn_Remove.Enabled = false;
                        break;
                    }
                }
            }
            else
            {
                btn_Remove.Enabled = false;
            }
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            FilterItems(tb_Search.Text);
        }

        private void FilterItems(string searchText)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchItemsQuery = "SELECT i.Item_ID as ID, c.Category_Name as Category, " +
                                         "i.Item_Name as Name, i.Item_NetWT as NetWT, " +
                                         "i.Item_Price as Price, i.Item_InStock as [In-Stock] " +
                                         "FROM tbl_Items i " +
                                         "INNER JOIN tbl_Categories c ON i.Category_ID = c.Category_ID " +
                                         "WHERE i.Item_Name LIKE @SearchText";

                SqlCommand fetchCommand = new(fetchItemsQuery, connection);
                fetchCommand.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Items = new();
                adapter.Fill(dt_Items);
                dgv_Items.DataSource = dt_Items;
            }
        }
    }
}
