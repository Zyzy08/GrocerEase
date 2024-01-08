using GrocerEase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sayra
{
    public partial class DiscountDetail : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public DiscountDetail()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        public string Mode { get; set; }

        public int DiscountId { get; internal set; }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            string discountType = tb_Type.Text.Trim();
            string discountRate = nud_Rate.Text.Trim();
            int status = cb_Status.SelectedIndex == 0 ? 1 : 0; // Map the selected index to IsActive

            if (string.IsNullOrWhiteSpace(discountType) || string.IsNullOrWhiteSpace(discountRate))
            {
                MessageBox.Show("Please enter valid discount type and rate.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection connection = new(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized."));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                if (Mode == "Add" && DiscountExists(connection, discountType))
                {
                    MessageBox.Show("Discount with the same type already exists.", "Duplicate Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;

                if (Mode == "Add")
                {
                    int newDiscountId = GetNextDiscountId(connection);
                    query = "INSERT INTO tbl_Discounts (Discount_ID, Discount_Type, Discount_Rate, IsActive) VALUES (@DiscountId, @DiscountType, @DiscountRate, @Status)";
                }
                else
                {
                    query = "UPDATE tbl_Discounts SET Discount_Type = @DiscountType, Discount_Rate = @DiscountRate, IsActive = @Status WHERE Discount_ID = @DiscountId";
                }

                using SqlCommand command = new(query, connection);

                if (Mode == "Add")
                {
                    command.Parameters.AddWithValue("@DiscountId", GetNextDiscountId(connection));
                }
                else
                {
                    command.Parameters.AddWithValue("@DiscountId", DiscountId);
                }

                command.Parameters.AddWithValue("@DiscountType", discountType);
                command.Parameters.AddWithValue("@DiscountRate", discountRate);
                command.Parameters.AddWithValue("@Status", status);

                command.ExecuteNonQuery();

                MessageBox.Show("Discount " + (Mode == "Add" ? "added" : "edited") + " successfully!");

                ResetForm();

                if (Mode == "Edit")
                {
                    this.Close();
                }
            }

            if (this.Owner is UI ui)
            {
                ui.Lbl_Discounts_Click(sender, e);
                ui.RefreshDiscountsForm();
            }
        }

        public static int GetNextDiscountId(SqlConnection connection)
        {
            int newDiscountId = 1;

            string queryCountDiscounts = "SELECT COUNT(*) FROM tbl_Discounts";
            using (SqlCommand commandCountDiscounts = new(queryCountDiscounts, connection))
            {
                int discountCount = Convert.ToInt32(commandCountDiscounts.ExecuteScalar());

                if (discountCount > 0)
                {
                    string queryAllDiscountIds = "SELECT Discount_ID FROM tbl_Discounts";
                    using SqlCommand commandAllDiscountIds = new(queryAllDiscountIds, connection);
                    using SqlDataReader reader = commandAllDiscountIds.ExecuteReader();
                    HashSet<int> existingIds = new();

                    while (reader.Read())
                    {
                        existingIds.Add(reader.GetInt32(0));
                    }

                    while (existingIds.Contains(newDiscountId))
                    {
                        newDiscountId++;
                    }
                }
            }

            return newDiscountId;
        }

        private static bool DiscountExists(SqlConnection connection, string discountType)
        {
            string query = "SELECT COUNT(*) FROM tbl_Discounts WHERE LOWER(Discount_Type) = LOWER(@DiscountType)";

            using (SqlCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@DiscountType", discountType.ToLower());

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        private void ResetForm()
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();
                lbl_ID.Text = GetNextDiscountId(connection).ToString();
            }

            tb_Type.Text = string.Empty;
            nud_Rate.Value = 1;
            cb_Status.SelectedIndex = -1;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscountDetail_Load(object sender, EventArgs e)
        {
            ResetForm();

            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    lbl_ID.Text = GetNextDiscountId(connection).ToString();
                }
            }

            if (Mode == "Edit")
            {
                lbl_Title.Text = "Edit discount";
                pnl_Title.BackColor = Color.SteelBlue;
                this.BackColor = Color.AliceBlue;

                LoadDiscountDataForEditing();
            }
        }

        private void LoadDiscountDataForEditing()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryDiscountDetails = "SELECT Discount_Type, Discount_Rate, IsActive FROM tbl_Discounts WHERE Discount_ID = @DiscountId";

                using SqlCommand commandDiscountDetails = new(queryDiscountDetails, connection);
                commandDiscountDetails.Parameters.AddWithValue("@DiscountId", DiscountId);

                using SqlDataReader readerDiscountDetails = commandDiscountDetails.ExecuteReader();

                if (readerDiscountDetails.Read())
                {
                    lbl_ID.Text = DiscountId.ToString();
                    tb_Type.Text = readerDiscountDetails["Discount_Type"].ToString();
                    nud_Rate.Text = readerDiscountDetails["Discount_Rate"].ToString();

                    // Map IsActive to the ComboBox selection
                    cb_Status.SelectedIndex = Convert.ToInt32(readerDiscountDetails["IsActive"]) == 1 ? 0 : 1;
                }
            }
        }
    }
}
