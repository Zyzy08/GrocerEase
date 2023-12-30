using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            ResetForm();

            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    lbl_ID.Text = GetNextItemId(connection).ToString();

                    string? queryCategories = "SELECT Category_Name FROM tbl_Categories";

                    using SqlCommand commandCategories = new(queryCategories, connection);
                    using SqlDataReader readerCategories = commandCategories.ExecuteReader();
                    while (readerCategories.Read())
                    {
                        string? categoryName = readerCategories["Category_Name"].ToString();
                        cb_Category.Items.Add(categoryName);
                    }
                }
            }

            cb_Category.SelectedIndex = 0;
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Choose an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private static bool IsDefaultImage(Image image)
        {
            byte[] defaultImageBytes = ImageToByteArray(Sayra.Properties.Resources.Upload);
            byte[] currentImageBytes = ImageToByteArray(image);
            return StructuralComparisons.StructuralEqualityComparer.Equals(defaultImageBytes, currentImageBytes);
        }

        private static byte[] ImageToByteArray(Image image)
        {
            using MemoryStream ms = new();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            int selectedCategoryIndex = cb_Category.SelectedIndex;

            string? itemName = txt_Name.Text;
            decimal itemPrice = nud_Price.Value;
            string? itemNetWeight = txt_NetWT.Text;
            int itemInStock = (int)nud_InStock.Value;

            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Please enter a valid product name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemPrice <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(itemNetWeight))
            {
                MessageBox.Show("Please enter a valid net weight.", "Missing Net Weight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[]? imageBytes;
            if (IsDefaultImage(pb_Image.Image))
            {
                imageBytes = null;
            }
            else
            {
                imageBytes = ImageToByteArray(pb_Image.Image);
            }

            using SqlConnection connection = new(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized."));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                int newItemID = GetNextItemId(connection);

                string insertQuery = @"INSERT INTO tbl_Items (Item_ID, Item_Name, Item_Price, Item_NetWT, Item_Icon, Item_InStock, Category_ID)
            VALUES (@ItemID, @ItemName, @ItemPrice, @ItemNetWeight, @ItemIcon, @ItemInStock, @CategoryID)";

                using SqlCommand command = new(insertQuery, connection);

                command.Parameters.AddWithValue("@ItemID", newItemID);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@ItemPrice", itemPrice);
                command.Parameters.AddWithValue("@ItemNetWeight", itemNetWeight);
                SqlParameter iconParameter = new("@ItemIcon", SqlDbType.VarBinary, -1)
                {
                    Value = imageBytes as object ?? DBNull.Value
                };
                command.Parameters.Add(iconParameter);

                command.Parameters.AddWithValue("@ItemInStock", itemInStock);
                command.Parameters.AddWithValue("@CategoryID", selectedCategoryIndex + 1);

                command.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");

                ResetForm();
            }

            if (this.Owner is UI ui)
            {
                ui.Lbl_Products_Click(sender, e);
                ui.RefreshProductsForm();
            }
        }

        private void ResetForm()
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();
                lbl_ID.Text = GetNextItemId(connection).ToString();

                cb_Category.Items.Clear();

                if (connection.State == ConnectionState.Open)
                {
                    string? queryCategories = "SELECT Category_Name FROM tbl_Categories";
                    using SqlCommand commandCategories = new(queryCategories, connection);
                    using SqlDataReader readerCategories = commandCategories.ExecuteReader();
                    while (readerCategories.Read())
                    {
                        string? categoryName = readerCategories["Category_Name"].ToString();
                        cb_Category.Items.Add(categoryName);
                    }
                }

                cb_Category.SelectedIndex = 0;
            }

            txt_Name.Text = string.Empty;
            nud_Price.Value = 0;
            txt_NetWT.Text = string.Empty;
            pb_Image.Image = Sayra.Properties.Resources.Upload;
            nud_InStock.Value = 0;
        }

        public static int GetNextItemId(SqlConnection connection)
        {
            string queryMinItemId = "SELECT MIN(Item_ID) + 1 FROM tbl_Items WHERE NOT EXISTS (SELECT 1 FROM tbl_Items AS t2 WHERE t2.Item_ID = tbl_Items.Item_ID + 1)";

            using SqlCommand commandMinItemId = new(queryMinItemId, connection);
            object minItemId = commandMinItemId.ExecuteScalar();

            return minItemId != null && minItemId != DBNull.Value ? Convert.ToInt32(minItemId) : 1;
        }
    }
}
