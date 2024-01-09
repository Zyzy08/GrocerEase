using Sayra;
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

        public void ReceiptData(int receiptID = -1)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    // Fetch receipt details
                    string receiptQuery = "SELECT * FROM tbl_Receipts WHERE Receipt_ID = @ReceiptID";

                    using (SqlCommand receiptCommand = new SqlCommand(receiptQuery, connection))
                    {
                        receiptCommand.Parameters.AddWithValue("@ReceiptID", receiptID);

                        using (SqlDataReader receiptReader = receiptCommand.ExecuteReader())
                        {
                            if (receiptReader.Read())
                            {
                                string cashierName = receiptReader["Cashier_Name"].ToString();
                                decimal total = Convert.ToDecimal(receiptReader["Receipt_Total"]);
                                DateTime dateTime = Convert.ToDateTime(receiptReader["Receipt_DateTime"]);

                                // Display receipt details
                                Console.WriteLine($"Receipt ID: {receiptID}");
                                Console.WriteLine($"Cashier: {cashierName}");
                                Console.WriteLine($"Total: {total:C}");
                                Console.WriteLine($"Date and Time: {dateTime}");
                                Console.WriteLine("Items:");

                                // Fetch items related to the receipt
                                string itemsQuery = "SELECT * FROM tbl_ReceiptItems WHERE Receipt_ID = @ReceiptID";

                                using (SqlCommand itemsCommand = new SqlCommand(itemsQuery, connection))
                                {
                                    itemsCommand.Parameters.AddWithValue("@ReceiptID", receiptID);

                                    using (SqlDataReader itemsReader = itemsCommand.ExecuteReader())
                                    {
                                        while (itemsReader.Read())
                                        {
                                            int receiptItemID = Convert.ToInt32(itemsReader["ReceiptItem_ID"]);
                                            string itemName = itemsReader["Item_Name"].ToString();
                                            int quantity = Convert.ToInt32(itemsReader["Item_Quantity"]);
                                            decimal price = Convert.ToDecimal(itemsReader["Item_Price"]);

                                            // Display item details
                                            Console.WriteLine($"  {receiptItemID}. {itemName} - Quantity: {quantity}, Price: {price:C}");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Receipt with ID {receiptID} not found.");
                            }
                        }
                    }
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

                    cashierNameReader.Close(); // Close the SqlDataReader here

                    cashierConnection.Close();

                    // Insert items into tbl_ReceiptItems with unique ReceiptItem_ID
                    int receiptItemID = 1; // Initialize the ReceiptItem_ID counter

                    string insertItemQuery = "INSERT INTO tbl_ReceiptItems (Receipt_ID, ReceiptItem_ID, Item_Name, Item_Quantity, Item_Price) VALUES (@ReceiptID, @ReceiptItemID, @ItemName, @Quantity, @Price)";

                    string query = "SELECT Item, Quantity, Price FROM tbl_TempList";

                    using SqlCommand command = new SqlCommand(query, connection);
                    using SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string itemName = reader["Item"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        // Increment the ReceiptItem_ID for each item
                        receiptItemID++;

                        // Insert the item into tbl_ReceiptItems with unique ReceiptItem_ID
                        using SqlCommand insertItemCommand = new SqlCommand(insertItemQuery, connection);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptItemID", receiptItemID);
                        insertItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCommand.Parameters.AddWithValue("@Price", price);

                        insertItemCommand.ExecuteNonQuery();
                    }
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

                    cashierNameReader.Close(); // Close the SqlDataReader here

                    cashierConnection.Close();

                    // Insert items into tbl_ReceiptItems with unique ReceiptItem_ID
                    int receiptItemID = 1; // Initialize the ReceiptItem_ID counter

                    string insertItemQuery = "INSERT INTO tbl_ReceiptItems (Receipt_ID, ReceiptItem_ID, Item_Name, Item_Quantity, Item_Price) VALUES (@ReceiptID, @ReceiptItemID, @ItemName, @Quantity, @Price)";

                    string query = "SELECT Item, Quantity, Price FROM tbl_TempList";

                    using SqlCommand command = new SqlCommand(query, connection);
                    using SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string itemName = reader["Item"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        // Increment the ReceiptItem_ID for each item
                        receiptItemID++;

                        // Insert the item into tbl_ReceiptItems with unique ReceiptItem_ID
                        using SqlCommand insertItemCommand = new SqlCommand(insertItemQuery, connection);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptItemID", receiptItemID);
                        insertItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCommand.Parameters.AddWithValue("@Price", price);

                        insertItemCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
