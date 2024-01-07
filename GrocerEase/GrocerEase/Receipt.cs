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

        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public Receipt(Label lbl_TotalPOS, Checkout checkoutForm)
        {
            InitializeComponent();
            InitializeVATLabels();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            this.lbl_TotalPOS = lbl_TotalPOS;
            this.checkoutForm = checkoutForm;

            DisplayTempListData();
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

        private void DisplayTempListData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
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

        }
    }
}
