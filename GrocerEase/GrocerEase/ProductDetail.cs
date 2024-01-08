using Sayra;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace GrocerEase
{
    public partial class ProductDetail : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public ProductDetail()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        public string Mode { get; set; }

        public int ItemId { get; internal set; }

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

                    cb_Category.Items.Clear();

                    while (readerCategories.Read())
                    {
                        string? categoryName = readerCategories["Category_Name"].ToString();
                        cb_Category.Items.Add(categoryName);
                    }
                }
            }

            cb_Category.SelectedIndex = 0;

            if (Mode == "Edit")
            {
                lbl_Title.Text = "Edit product";
                pnl_Title.BackColor = Color.SteelBlue;
                this.BackColor = Color.AliceBlue;
                LoadProductDataForEditing();
            }
        }

        private void LoadProductDataForEditing()
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

            string itemName = tb_Name.Text.Trim();
            decimal itemPrice = nud_Price.Value;
            string itemNetWeight = tb_NetWT.Text.Trim();
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

            using SqlConnection connection = new(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized."));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                if (Mode == "Add")
                {
                    if (ItemExists(connection, itemName, itemNetWeight))
                    {
                        MessageBox.Show("An item with the same name and net weight already exists.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query;

                if (Mode == "Add")
                {
                    int newItemID = GetNextItemId(connection);

                    query = @"INSERT INTO tbl_Items (Item_ID, Item_Name, Item_Price, Item_NetWT, Item_Icon, Item_InStock, Category_ID)
                    VALUES (@ItemID, @ItemName, @ItemPrice, @ItemNetWeight, @ItemIcon, @ItemInStock, @CategoryID)";
                }
                else
                {
                    query = @"UPDATE tbl_Items SET Item_Name = @ItemName, Item_Price = @ItemPrice, Item_NetWT = @ItemNetWeight, 
                    Item_Icon = @ItemIcon, Item_InStock = @ItemInStock, Category_ID = @CategoryID WHERE Item_ID = @ItemID";
                }

                using SqlCommand command = new(query, connection);

                if (Mode == "Add")
                {
                    command.Parameters.AddWithValue("@ItemID", GetNextItemId(connection));
                }
                else
                {
                    command.Parameters.AddWithValue("@ItemID", ItemId);
                }

                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@ItemPrice", itemPrice);
                command.Parameters.AddWithValue("@ItemNetWeight", itemNetWeight);

                SqlParameter iconParameter = new("@ItemIcon", SqlDbType.VarBinary, -1)
                {
                    Value = IsDefaultImage(pb_Image.Image) ? DBNull.Value : (object)ImageToByteArray(pb_Image.Image)
                };

                command.Parameters.Add(iconParameter);

                command.Parameters.AddWithValue("@ItemInStock", itemInStock);
                command.Parameters.AddWithValue("@CategoryID", selectedCategoryIndex + 1);

                command.ExecuteNonQuery();

                CommonUtilities.UpdateCategoryInStock(connection);

                MessageBox.Show("Product " + (Mode == "Add" ? "added" : "edited") + " successfully!");

                ResetForm();

                if (Mode == "Edit")
                {
                    this.Close();
                }
            }

            if (this.Owner is UI ui)
            {
                ui.Lbl_Products_Click(sender, e);
                ui.RefreshProductsForm();
            }
        }

        private static bool ItemExists(SqlConnection connection, string itemName, string itemNetWeight)
        {
            string query = "SELECT COUNT(*) FROM tbl_Items WHERE LOWER(Item_Name) = LOWER(@ItemName) AND LOWER(Item_NetWT) = LOWER(@ItemNetWeight)";

            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@ItemName", itemName.ToLower());
            command.Parameters.AddWithValue("@ItemNetWeight", itemNetWeight.ToLower());

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count > 0;
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

            tb_Name.Text = string.Empty;
            nud_Price.Value = 0;
            tb_NetWT.Text = string.Empty;
            pb_Image.Image = Sayra.Properties.Resources.Upload;
            nud_InStock.Value = 0;
        }

        public static int GetNextItemId(SqlConnection connection)
        {
            int newItemId = 1;

            string queryCountItems = "SELECT COUNT(*) FROM tbl_Items";
            using (SqlCommand commandCountItems = new(queryCountItems, connection))
            {
                int itemCount = Convert.ToInt32(commandCountItems.ExecuteScalar());

                if (itemCount > 0)
                {
                    string queryAllItemIds = "SELECT Item_ID FROM tbl_Items";
                    using SqlCommand commandAllItemIds = new(queryAllItemIds, connection);
                    using SqlDataReader reader = commandAllItemIds.ExecuteReader();
                    HashSet<int> existingIds = [];

                    while (reader.Read())
                    {
                        existingIds.Add(reader.GetInt32(0));
                    }

                    while (existingIds.Contains(newItemId))
                    {
                        newItemId++;
                    }
                }
            }

            return newItemId;
        }
    }
}
