using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sayra
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            dgv_Receipts.SelectionChanged += Dgv_Receipts_SelectionChanged;
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadReceiptsData();
        }

        private void LoadReceiptsData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchReceiptsQuery = "SELECT Receipt_ID as ID, " +
                                           "CONCAT(N'₱', Receipt_Total) as Total, " +
                                           "Cashier_Name as Cashier, " +
                                           "FORMAT(Receipt_DateTime, 'MMMM d, yyyy') as Date, " +
                                           "FORMAT(Receipt_DateTime, 'h:mm tt') as Time " +
                                           "FROM tbl_Receipts";

                using SqlCommand fetchCommand = new(fetchReceiptsQuery, connection);
                using SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Receipts = new();
                adapter.Fill(dt_Receipts);

                dgv_Receipts.DataSource = dt_Receipts;
            }
        }

        private void Dgv_Receipts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Receipts.SelectedRows.Count > 0)
            {
                int selectedReceiptID = Convert.ToInt32(dgv_Receipts.SelectedRows[0].Cells["ID"].Value);
                LoadReceiptItemsData(selectedReceiptID);
            }
        }

        private void LoadReceiptItemsData(int receiptID)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchReceiptItemsQuery = "SELECT ReceiptItem_ID, Receipt_ID, Item_Name, Item_Quantity, " +
                                                "CONCAT(N'₱', Item_Price) as Item_Price " +
                                                "FROM tbl_ReceiptItems " +
                                                "WHERE Receipt_ID = @ReceiptID";

                using SqlCommand fetchItemsCommand = new(fetchReceiptItemsQuery, connection);
                fetchItemsCommand.Parameters.AddWithValue("@ReceiptID", receiptID);

                using SqlDataAdapter itemsAdapter = new(fetchItemsCommand);
                DataTable dt_ReceiptItems = new();
                itemsAdapter.Fill(dt_ReceiptItems);

                dgv_ReceiptItems.DataSource = dt_ReceiptItems;

                dgv_ReceiptItems.Columns["Item_Name"].HeaderText = "Item";
                dgv_ReceiptItems.Columns["Item_Quantity"].HeaderText = "Quantity";
                dgv_ReceiptItems.Columns["Item_Price"].HeaderText = "Price";

                dgv_ReceiptItems.Columns["ReceiptItem_ID"].Visible = false;
                dgv_ReceiptItems.Columns["Receipt_ID"].Visible = false;
            }
        }
    }
}
