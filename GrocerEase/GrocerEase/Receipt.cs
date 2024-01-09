﻿using Sayra;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrocerEase
{
    public partial class Receipt : Form
    {
        private readonly Label lbl_TotalPOS;
        private readonly Checkout checkoutForm;
        private readonly string SubtotalText;
        private readonly string VATText;
        private readonly string DiscountsText;
        private readonly string TotalText;
        private readonly string CashText;
        private readonly string ChangeText;
        private readonly int cashierID;

        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public Receipt(Label lbl_TotalPOS, Checkout checkoutForm, string SubtotalText, string VATText, string DiscountsText, string TotalText, string CashText, string ChangeText, int cashierID)
        {
            InitializeComponent();
            InitializeVATLabels();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            this.lbl_TotalPOS = lbl_TotalPOS;
            this.checkoutForm = checkoutForm;
            this.SubtotalText = SubtotalText;
            this.VATText = VATText;
            this.DiscountsText = DiscountsText;
            this.TotalText = TotalText;
            this.CashText = CashText;
            this.ChangeText = ChangeText;
            this.cashierID = cashierID;

            ReceiptData();

            lbl_DateTime.Text = "Date: " + DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
            lbl_Subtotal.Text = this.SubtotalText;
            lbl_VAT.Text = this.VATText;
            lbl_Discounts.Text = this.DiscountsText;
            lbl_Total.Text = "₱" + this.TotalText;
            lbl_Cash.Text = "₱" + this.CashText;
            lbl_Change.Text = "₱" + this.ChangeText;

            DisplayCashierInformation();
        }

        private void DisplayCashierInformation()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string query = "SELECT Employee_FirstName, Employee_LastName FROM tbl_Users WHERE Employee_ID = @EmployeeID";

                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", cashierID);

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string firstName = reader["Employee_FirstName"].ToString();
                    string lastName = reader["Employee_LastName"].ToString();

                    lbl_Cashier.Text = $"Cashier: {lastName}, {firstName} #{cashierID:D8}";
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            checkoutForm.Visible = true;
            this.Close();
        }

        private void InitializeVATLabels()
        {
            lv_List.View = View.Details;
            lv_List.Columns.Add("Item", -2, HorizontalAlignment.Left);
            lv_List.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            lv_List.Columns.Add("Price", -2, HorizontalAlignment.Left);
        }

        private void ReceiptData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string receiptIDQuery = "SELECT TOP 1 RIGHT('0000000000' + CAST(Receipt_ID AS VARCHAR(10)), 10) AS FormattedReceiptID FROM tbl_Receipts ORDER BY Receipt_ID DESC";

                using SqlCommand receiptIDCommand = new(receiptIDQuery, connection);
                object result = receiptIDCommand.ExecuteScalar();

                string Receipt_ID;

                if (result != null)
                {
                    Receipt_ID = result.ToString();
                }
                else
                {
                    Receipt_ID = "0000000001";
                }

                lbl_ReceiptNo.Text = "Receipt #: " + Receipt_ID;

                string query = "SELECT Item, Quantity, Price FROM tbl_TempList";

                using SqlCommand command = new(query, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string itemName = reader["Item"].ToString();
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    decimal price = Convert.ToDecimal(reader["Price"]);

                    ListViewItem item = new(itemName);
                    item.SubItems.Add($"x{quantity}");
                    item.SubItems.Add($"₱{price:N2}");

                    lv_List.Items.Add(item);
                }
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string receiptIDQuery = "SELECT TOP 1 Receipt_ID FROM tbl_Receipts ORDER BY Receipt_ID DESC";

                using SqlCommand receiptIDCommand = new SqlCommand(receiptIDQuery, connection);
                object result = receiptIDCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int latestReceiptID))
                {
                    int newReceiptID = latestReceiptID + 1;

                    using SqlConnection cashierConnection = new SqlConnection(DatabaseManager.ConnectionString);
                    cashierConnection.Open();

                    string cashierNameQuery = "SELECT Employee_FirstName, Employee_LastName FROM tbl_Users WHERE Employee_ID = @EmployeeID";

                    using SqlCommand cashierNameCommand = new SqlCommand(cashierNameQuery, cashierConnection);
                    cashierNameCommand.Parameters.AddWithValue("@EmployeeID", cashierID);

                    using SqlDataReader cashierNameReader = cashierNameCommand.ExecuteReader();
                    string cashierFirstName = string.Empty;
                    string cashierLastName = string.Empty;

                    if (cashierNameReader.Read())
                    {
                        cashierFirstName = cashierNameReader["Employee_FirstName"].ToString();
                        cashierLastName = cashierNameReader["Employee_LastName"].ToString();
                    }

                    string insertQuery = "INSERT INTO tbl_Receipts (Receipt_ID, Receipt_Total, Cashier_Name, Receipt_DateTime) VALUES (@ReceiptID, @Total, @CashierName, @DateTime)";

                    using SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                    insertCommand.Parameters.AddWithValue("@Total", TotalText);
                    insertCommand.Parameters.AddWithValue("@CashierName", $"{cashierLastName}, {cashierFirstName}");
                    insertCommand.Parameters.AddWithValue("@DateTime", DateTime.Now);

                    insertCommand.ExecuteNonQuery();

                    // Insert items into tbl_ReceiptItems
                    foreach (ListViewItem item in lv_List.Items)
                    {
                        string itemName = item.SubItems[0].Text;
                        int quantity = int.Parse(item.SubItems[1].Text.Substring(1)); // Remove 'x' and convert to int
                        decimal price = decimal.Parse(item.SubItems[2].Text.Substring(1)); // Remove '₱' and convert to decimal

                        string insertItemQuery = "INSERT INTO tbl_ReceiptItems (Receipt_ID, Item_Name, Item_Quantity, Item_Price) VALUES (@ReceiptID, @ItemName, @Quantity, @Price)";

                        using SqlCommand insertItemCommand = new SqlCommand(insertItemQuery, connection);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                        insertItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCommand.Parameters.AddWithValue("@Price", price);

                        insertItemCommand.ExecuteNonQuery();
                    }

                    cashierNameReader.Close();
                    cashierConnection.Close();
                }
                else
                {
                    int newReceiptID = 1;

                    using SqlConnection cashierConnection = new SqlConnection(DatabaseManager.ConnectionString);
                    cashierConnection.Open();

                    string cashierNameQuery = "SELECT Employee_FirstName, Employee_LastName FROM tbl_Users WHERE Employee_ID = @EmployeeID";

                    using SqlCommand cashierNameCommand = new SqlCommand(cashierNameQuery, cashierConnection);
                    cashierNameCommand.Parameters.AddWithValue("@EmployeeID", cashierID);

                    using SqlDataReader cashierNameReader = cashierNameCommand.ExecuteReader();
                    string cashierFirstName = string.Empty;
                    string cashierLastName = string.Empty;

                    if (cashierNameReader.Read())
                    {
                        cashierFirstName = cashierNameReader["Employee_FirstName"].ToString();
                        cashierLastName = cashierNameReader["Employee_LastName"].ToString();
                    }

                    string insertQuery = "INSERT INTO tbl_Receipts (Receipt_ID, Receipt_Total, Cashier_Name, Receipt_DateTime) VALUES (@ReceiptID, @Total, @CashierName, @DateTime)";

                    using SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                    insertCommand.Parameters.AddWithValue("@Total", TotalText);
                    insertCommand.Parameters.AddWithValue("@CashierName", $"{cashierLastName}, {cashierFirstName}");
                    insertCommand.Parameters.AddWithValue("@DateTime", DateTime.Now);

                    insertCommand.ExecuteNonQuery();

                    // Insert items into tbl_ReceiptItems
                    foreach (ListViewItem item in lv_List.Items)
                    {
                        string itemName = item.SubItems[0].Text;
                        int quantity = int.Parse(item.SubItems[1].Text.Substring(1)); // Remove 'x' and convert to int
                        decimal price = decimal.Parse(item.SubItems[2].Text.Substring(1)); // Remove '₱' and convert to decimal

                        string insertItemQuery = "INSERT INTO tbl_ReceiptItems (Receipt_ID, Item_Name, Item_Quantity, Item_Price) VALUES (@ReceiptID, @ItemName, @Quantity, @Price)";

                        using SqlCommand insertItemCommand = new SqlCommand(insertItemQuery, connection);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                        insertItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCommand.Parameters.AddWithValue("@Price", price);

                        insertItemCommand.ExecuteNonQuery();
                    }

                    cashierNameReader.Close();
                    cashierConnection.Close();
                }
            }
        }
    }
}
