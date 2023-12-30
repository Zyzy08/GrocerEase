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
        public event EventHandler DataUpdated;

        public ProductDetail()
        {
            InitializeComponent();
            PopulateCategories();
        }

        public int ItemId { get; set; }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryItemDetails = "SELECT Item_Name, Item_Price, Item_NetWT, Item_Icon, Item_InStock, Category_ID FROM tbl_Items WHERE Item_ID = @ItemId";

                using SqlCommand commandItemDetails = new(queryItemDetails, connection);
                commandItemDetails.Parameters.AddWithValue("@ItemId", ItemId);

                using SqlDataReader readerItemDetails = commandItemDetails.ExecuteReader();

                if (readerItemDetails.Read())
                {
                    lbl_ID.Text = ItemId.ToString();
                    tb_Name.Text = readerItemDetails["Item_Name"].ToString();
                    nud_Price.Value = Convert.ToDecimal(readerItemDetails["Item_Price"]);
                    tb_NetWT.Text = readerItemDetails["Item_NetWT"].ToString();
                    nud_InStock.Value = Convert.ToInt32(readerItemDetails["Item_InStock"]);

                    if (cb_Category.Items.Count > 0)
                    {
                        int categoryId = Convert.ToInt32(readerItemDetails["Category_ID"]);
                        cb_Category.SelectedIndex = categoryId - 1;
                    }

                    if (readerItemDetails["Item_Icon"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])readerItemDetails["Item_Icon"];
                        pb_Image.Image = ByteArrayToImage(imageBytes);
                    }
                }
            }
        }

        private void PopulateCategories()
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string queryCategories = "SELECT Category_Name FROM tbl_Categories";

                    using SqlCommand commandCategories = new(queryCategories, connection);
                    using SqlDataReader readerCategories = commandCategories.ExecuteReader();

                    while (readerCategories.Read())
                    {
                        string categoryName = readerCategories["Category_Name"].ToString();
                        cb_Category.Items.Add(categoryName);
                    }
                }
            }
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using MemoryStream ms = new(byteArray);
            Image image = Image.FromStream(ms);
            return image;
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

        private static int GetNewItemId(SqlConnection connection)
        {
            string queryLatestItemID = "SELECT TOP 1 Item_ID FROM tbl_Items ORDER BY Item_ID DESC";

            using SqlCommand commandLatestItemID = new(queryLatestItemID, connection);
            object latestItemID = commandLatestItemID.ExecuteScalar();

            return latestItemID != null && latestItemID != DBNull.Value ? Convert.ToInt32(latestItemID) + 1 : 1;
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
            if (this.Owner is UI ui)
            {
                ui.Lbl_Products_Click(sender, e);
                ui.RefreshProductsForm();
            }

            this.Close();
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            int selectedCategoryIndex = cb_Category.SelectedIndex;

            // Retrieve values from controls
            int itemId = Convert.ToInt32(lbl_ID.Text);
            string itemName = tb_Name.Text;
            decimal itemPrice = nud_Price.Value;
            string itemNetWeight = tb_NetWT.Text;
            int itemInStock = (int)nud_InStock.Value;

            byte[] imageBytes;
            if (IsDefaultImage(pb_Image.Image))
            {
                imageBytes = null;
            }
            else
            {
                imageBytes = ImageToByteArray(pb_Image.Image);
            }

            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized.")))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    // Check if the product with the given ID already exists in the database
                    bool productExists = CheckIfProductExists(connection, itemId);

                    string query;
                    SqlCommand command;

                    if (productExists)
                    {
                        // Update existing product
                        query = @"UPDATE tbl_Items
                          SET Item_Name = @ItemName,
                              Item_Price = @ItemPrice,
                              Item_NetWT = @ItemNetWeight,
                              Item_Icon = @ItemIcon,
                              Item_InStock = @ItemInStock,
                              Category_ID = @CategoryID
                          WHERE Item_ID = @ItemID";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ItemID", itemId);
                    }
                    else
                    {
                        // Insert new product
                        query = @"INSERT INTO tbl_Items (Item_ID, Item_Name, Item_Price, Item_NetWT, Item_Icon, Item_InStock, Category_ID)
                          VALUES (@ItemID, @ItemName, @ItemPrice, @ItemNetWeight, @ItemIcon, @ItemInStock, @CategoryID)";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ItemID", itemId);
                    }

                    // Set common parameters
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@ItemPrice", itemPrice);
                    command.Parameters.AddWithValue("@ItemNetWeight", itemNetWeight);
                    SqlParameter iconParameter = new SqlParameter("@ItemIcon", SqlDbType.VarBinary, -1)
                    {
                        Value = imageBytes as object ?? DBNull.Value
                    };
                    command.Parameters.Add(iconParameter);
                    command.Parameters.AddWithValue("@ItemInStock", itemInStock);
                    command.Parameters.AddWithValue("@CategoryID", selectedCategoryIndex + 1);

                    command.ExecuteNonQuery();

                    MessageBox.Show(productExists ? "Product updated successfully!" : "Product added successfully!");

                    if (this.Owner is UI ui)
                    {
                        Products products = ui.GetSelectedTabContent() as Products;
                        products?.DataUpdated?.Invoke(products, EventArgs.Empty); // Trigger the event
                    }

                    this.Close();
                }
            }
        }

        private bool CheckIfProductExists(SqlConnection connection, int itemId)
        {
            string query = "SELECT COUNT(*) FROM tbl_Items WHERE Item_ID = @ItemID";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemId);
            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
    }
}
