using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            t_DateTime.Tick += DateTime_Tick;
            t_DateTime.Start();
        }

        private void DateTime_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string productsQuery = "SELECT COUNT(*) FROM tbl_Items";
                using SqlCommand productsCommand = new(productsQuery, connection);
                int totalProducts = Convert.ToInt32(productsCommand.ExecuteScalar());
                lbl_Products.Text = $"{totalProducts}";

                string inventoryQuery = "SELECT SUM(Item_InStock) FROM tbl_Items";
                using SqlCommand inventoryCommand = new(inventoryQuery, connection);
                object inventoryResult = inventoryCommand.ExecuteScalar();

                if (inventoryResult != null && inventoryResult != DBNull.Value)
                {
                    int totalInStock = Convert.ToInt32(inventoryResult);
                    lbl_Inventory.Text = $"{totalInStock}";
                }
                else
                {
                    lbl_Inventory.Text = "0";
                }

                string outOfStockQuery = "SELECT COUNT(*) FROM tbl_Items WHERE Item_InStock = 0";
                using SqlCommand outOfStockCommand = new(outOfStockQuery, connection);
                int totalOutOfStock = Convert.ToInt32(outOfStockCommand.ExecuteScalar());
                lbl_OutOfStocks.Text = $"{totalOutOfStock}";
            }
        }
    }
}
