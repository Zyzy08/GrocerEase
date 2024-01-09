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
        public bool IsCompleted;

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
            checkoutForm.IsCompleted = this.IsCompleted;
            checkoutForm.Checkout_Load(sender, e);
            this.Hide();
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

                try
                {
                    using SqlCommand receiptIDCommand = new(receiptIDQuery, connection);
                    object result = receiptIDCommand.ExecuteScalar();

                    int latestReceiptID = result != null ? int.Parse(result.ToString()) : 0;

                    if (latestReceiptID == 0)
                    {
                        latestReceiptID = 1;
                    }

                    lbl_ReceiptNo.Text = "Receipt #: " + latestReceiptID;

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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string receiptIDQuery = "SELECT TOP 1 Receipt_ID FROM tbl_Receipts ORDER BY Receipt_ID DESC";

                try
                {
                    using SqlCommand receiptIDCommand = new(receiptIDQuery, connection);
                    object result = receiptIDCommand.ExecuteScalar();

                    int latestReceiptID = result != null ? int.Parse(result.ToString()) : 0;

                    if (latestReceiptID < 1)
                    {
                        latestReceiptID = 0;
                    }

                    int newReceiptID = latestReceiptID + 1;

                    using SqlConnection cashierConnection = new(DatabaseManager.ConnectionString);
                    cashierConnection.Open();

                    string cashierNameQuery = "SELECT Employee_FirstName, Employee_LastName FROM tbl_Users WHERE Employee_ID = @EmployeeID";

                    using SqlCommand cashierNameCommand = new(cashierNameQuery, cashierConnection);
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

                    using SqlCommand insertCommand = new(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                    insertCommand.Parameters.AddWithValue("@Total", TotalText);
                    insertCommand.Parameters.AddWithValue("@CashierName", $"{cashierLastName}, {cashierFirstName}");
                    insertCommand.Parameters.AddWithValue("@DateTime", DateTime.Now);

                    insertCommand.ExecuteNonQuery();

                    string receiptItemIDQuery = "SELECT TOP 1 ReceiptItem_ID FROM tbl_ReceiptItems ORDER BY ReceiptItem_ID DESC";

                    using SqlCommand receiptItemIDCommand = new(receiptItemIDQuery, connection);
                    object receiptItemIDResult = receiptItemIDCommand.ExecuteScalar();

                    int latestReceiptItemID = receiptItemIDResult != null ? int.Parse(receiptItemIDResult.ToString()) : 0;

                    if (latestReceiptItemID < 1)
                    {
                        latestReceiptItemID = 0;
                    }

                    int newReceiptItemID = latestReceiptItemID + 1;

                    foreach (ListViewItem item in lv_List.Items)
                    {
                        string itemName = item.SubItems[0].Text;
                        int quantity = int.Parse(item.SubItems[1].Text[1..]);
                        decimal price = decimal.Parse(item.SubItems[2].Text[1..]);

                        string insertItemQuery = "INSERT INTO tbl_ReceiptItems (ReceiptItem_ID, Receipt_ID, Item_Name, Item_Quantity, Item_Price) VALUES (@ReceiptItemID, @ReceiptID, @ItemName, @Quantity, @Price)";

                        using SqlCommand insertItemCommand = new(insertItemQuery, connection);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptItemID", newReceiptItemID);
                        insertItemCommand.Parameters.AddWithValue("@ReceiptID", newReceiptID);
                        insertItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertItemCommand.Parameters.AddWithValue("@Price", price);

                        insertItemCommand.ExecuteNonQuery();

                        UpdateInStockQuantity(itemName, quantity);

                        newReceiptItemID++;
                    }

                    cashierNameReader.Close();
                    cashierConnection.Close();

                    MessageBox.Show("Transaction Complete! Next Customer Please.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IsCompleted = true;

                    Btn_Cancel_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateInStockQuantity(string itemName, int soldQuantity)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string inStockQuery = "SELECT Item_InStock FROM tbl_Items WHERE Item_Name = @ItemName";

                using SqlCommand inStockCommand = new(inStockQuery, connection);
                inStockCommand.Parameters.AddWithValue("@ItemName", itemName);

                int currentInStock = Convert.ToInt32(inStockCommand.ExecuteScalar());

                int newInStock = currentInStock - soldQuantity;

                string updateInStockQuery = "UPDATE tbl_Items SET Item_InStock = @NewInStock WHERE Item_Name = @ItemName";

                using SqlCommand updateInStockCommand = new(updateInStockQuery, connection);
                updateInStockCommand.Parameters.AddWithValue("@NewInStock", newInStock);
                updateInStockCommand.Parameters.AddWithValue("@ItemName", itemName);

                updateInStockCommand.ExecuteNonQuery();
            }
        }
    }
}
