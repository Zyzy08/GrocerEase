using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Discounts : Form
    {
        public Discounts()
        {
            InitializeComponent();
            dgv_Discounts.DefaultCellStyle.Font = new Font("Comforta", 10, FontStyle.Regular);
        }

        private void Discounts_Load(object sender, EventArgs e)
        {
            dgv_Discounts.SelectionChanged += Dgv_Discounts_SelectionChanged;
            tb_Search.TextChanged += Tb_Search_TextChanged;

            LoadDiscountData();

            dgv_Discounts.CellFormatting += Dgv_Discounts_CellFormatting;
        }

        private void LoadDiscountData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string fetchDiscountsQuery = "SELECT Discount_ID as ID, Discount_Type as Type, Discount_Rate as Rate, " +
                                             "CASE WHEN IsActive = 1 THEN 'Enabled' ELSE 'Disabled' END as Status " +
                                             "FROM tbl_Discounts";

                SqlCommand fetchCommand = new(fetchDiscountsQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Discounts = new();
                adapter.Fill(dt_Discounts);
                dgv_Discounts.DataSource = dt_Discounts;
            }
        }

        private void Dgv_Discounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgv_Discounts.Columns["Rate"].Index && e.RowIndex >= 0)
            {
                e.Value = $"{e.Value}%";
                e.FormattingApplied = true;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            // Add your code for adding a discount
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            // Add your code for editing a discount
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            // Add your code for removing a discount
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            FilterDiscounts(tb_Search.Text);
        }

        private void FilterDiscounts(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadDiscountData();
            }
            else
            {
                using SqlConnection connection = new(DatabaseManager.ConnectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string fetchDiscountsQuery = "SELECT Discount_ID as ID, Discount_Type as Type, Discount_Rate as Rate, IsActive as Status " +
                                                 "FROM tbl_Discounts " +
                                                 "WHERE Discount_Type LIKE @SearchText";

                    SqlCommand fetchCommand = new(fetchDiscountsQuery, connection);
                    fetchCommand.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    SqlDataAdapter adapter = new(fetchCommand);
                    DataTable dt_Discounts = new();
                    adapter.Fill(dt_Discounts);
                    dgv_Discounts.DataSource = dt_Discounts;
                }
            }
        }

        private void Dgv_Discounts_SelectionChanged(object sender, EventArgs e)
        {
            // Add your code for handling selection changes
        }
    }
}
