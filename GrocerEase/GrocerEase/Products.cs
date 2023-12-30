using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class Products : Form
    {
        public event EventHandler DataUpdated;

        public Products()
        {
            InitializeComponent();
            DataUpdated += Products_DataUpdated;
        }

        private void Lbl_POS_Click(object sender, EventArgs e)
        {
            UI pos = new();
            pos.Show();
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Products_Load(object sender, EventArgs e)
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

            dgv_Items.SelectionChanged += Dgv_Items_SelectionChanged;
        }

        private void Products_DataUpdated(object sender, EventArgs e)
        {
            // Refresh data when the Products form notifies of an update
            RefreshProducts();
        }

        public void RefreshData()
        {
            using SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString);
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

            OnDataUpdated(EventArgs.Empty);  // Invoke the event
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ProductDetail productdetail = new()
            {
                Owner = this.ParentForm
            };
            productdetail.ShowDialog();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Items.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove selected item(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new(DatabaseManager.ConnectionString);
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        foreach (DataGridViewRow selectedRow in dgv_Items.SelectedRows)
                        {
                            int itemId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                            string removeItemQuery = "DELETE FROM tbl_Items WHERE Item_ID = @ItemId";
                            SqlCommand removeCommand = new(removeItemQuery, connection);
                            removeCommand.Parameters.AddWithValue("@ItemId", itemId);

                            int rowsAffected = removeCommand.ExecuteNonQuery();

                            if (rowsAffected <= 0)
                            {
                                MessageBox.Show($"Failed to remove item with ID {itemId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        RefreshData();
                        MessageBox.Show("Selected item(s) removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Dgv_Items_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Items.SelectedRows.Count == 1)
            {
                btn_Edit.Enabled = true;
            }
            else
            {
                btn_Edit.Enabled = false;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Items.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Items.SelectedRows[0].Index;
                int itemId = Convert.ToInt32(dgv_Items.Rows[selectedRowIndex].Cells["ID"].Value);

                ProductDetail productDetailForm = new ProductDetail
                {
                    ItemId = itemId
                };

                // Subscribe to the event when creating the ProductDetail form
                productDetailForm.DataUpdated += ProductDetailForm_DataUpdated;

                productDetailForm.ShowDialog();
            }
        }

        private void ProductDetailForm_DataUpdated(object sender, EventArgs e)
        {
            // Refresh data when the ProductDetail form notifies of an update
            RefreshData();
        }

        protected virtual void OnDataUpdated(EventArgs e)
        {
            DataUpdated?.Invoke(this, e);
        }
    }
}
