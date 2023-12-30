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
        public Products()
        {
            InitializeComponent();
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
            dgv_Items.SelectionChanged += Dgv_Items_SelectionChanged;

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
        }
    }
}
