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
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            using DiscountDetail discountDetail = new();
            discountDetail.Mode = "Add";
            discountDetail.lbl_ID.Text = DiscountDetail.GetNextDiscountId(connection).ToString();
            discountDetail.Owner = this.ParentForm;
            discountDetail.ShowDialog();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Discounts.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Discounts.SelectedRows[0].Index;
                int discountId = Convert.ToInt32(dgv_Discounts.Rows[selectedRowIndex].Cells["ID"].Value);

                using SqlConnection connection = new(DatabaseManager.ConnectionString);
                connection.Open();

                using DiscountDetail discountDetailForm = new();
                discountDetailForm.Mode = "Edit";
                discountDetailForm.DiscountId = discountId;
                discountDetailForm.Owner = this.ParentForm;
                discountDetailForm.ShowDialog();

                RefreshData();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Discounts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected discount/discounts?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new(DatabaseManager.ConnectionString);
                    connection.Open();

                    foreach (DataGridViewRow selectedRow in dgv_Discounts.SelectedRows)
                    {
                        int discountID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        string removeDiscountQuery = "DELETE FROM tbl_Discounts WHERE Discount_ID = @DiscountID";
                        using SqlCommand removeDiscountCommand = new(removeDiscountQuery, connection);
                        removeDiscountCommand.Parameters.AddWithValue("@DiscountID", discountID);
                        removeDiscountCommand.ExecuteNonQuery();
                    }

                    RefreshData();
                }
            }
        }

        public void RefreshData()
        {
            LoadDiscountData();
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
            btn_Edit.Enabled = dgv_Discounts.SelectedRows.Count == 1;

            btn_Remove.Enabled = dgv_Discounts.SelectedRows.Count > 0;

            if (btn_Remove.Enabled)
            {
                foreach (DataGridViewRow selectedRow in dgv_Discounts.SelectedRows)
                {
                    string status = selectedRow.Cells["Status"].Value?.ToString();

                    btn_Remove.Enabled = string.Equals(status, "Disabled", StringComparison.OrdinalIgnoreCase);
                }
            }
        }
    }
}
