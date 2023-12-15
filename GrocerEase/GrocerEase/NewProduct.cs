using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        public string? connectionString = "Data Source=DESKTOP-BB2GC4I;Initial Catalog=db_GrocerEase;Integrated Security=True;Encrypt=False;";

        private void NewProduct_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string queryLatestItemID = "SELECT TOP 1 Item_ID FROM tbl_Items ORDER BY Item_ID DESC";

                    using SqlCommand commandLatestItemID = new(queryLatestItemID, connection);
                    object latestItemID = commandLatestItemID.ExecuteScalar();

                    int newItemID = (latestItemID == DBNull.Value) ? 1 : ((int)latestItemID + 1);

                    lbl_ID.Text = newItemID.ToString();
                }
            }

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

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
            }

            cb_Category.SelectedIndex = 0;

            PopulateSubcategories();

            cb_Category.SelectedIndexChanged += (cbCategorySender, cbCategoryEvent) =>
            {
                PopulateSubcategories();
            };
        }

        private void PopulateSubcategories()
        {
            cb_SubCategory.Items.Clear();

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string? querySubcategories = "SELECT SubCategory_Name FROM tbl_SubCategories WHERE Category_ID = (SELECT Category_ID FROM tbl_Categories WHERE Category_Name = @SelectedCategory)";

                    using SqlCommand commandSubcategories = new(querySubcategories, connection);
                    commandSubcategories.Parameters.AddWithValue("@SelectedCategory", cb_Category.SelectedItem.ToString());

                    using SqlDataReader readerSubcategories = commandSubcategories.ExecuteReader();
                    while (readerSubcategories.Read())
                    {
                        string? subcategoryName = readerSubcategories["SubCategory_Name"].ToString();
                        cb_SubCategory.Items.Add(subcategoryName);
                    }
                }
            }

            if (cb_SubCategory.Items.Count > 0)
            {
                cb_SubCategory.SelectedIndex = 0;
            }
        }

        private void Pb_Image_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Choose an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

        private void StockManagement_btn_Done_Click(object sender, EventArgs e)
        {
            _ = cb_Category.SelectedItem?.ToString();
            string? selectedSubcategory = cb_SubCategory.SelectedItem?.ToString();
            string? itemName = txt_Name.Text;
            decimal itemPrice = nud_Price.Value;
            string? itemDetails = txt_Details.Text;
            DateTime itemExpirationDate = dtp_Expiration.Value;

            byte[] imageBytes = ImageToByteArray(pb_Image.Image);

            using SqlConnection connection = new(connectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryLatestItemID = "SELECT TOP 1 Item_ID FROM tbl_Items ORDER BY Item_ID DESC";

                using SqlCommand commandLatestItemID = new(queryLatestItemID, connection);
                object latestItemID = commandLatestItemID.ExecuteScalar();

                int newItemID = (latestItemID == DBNull.Value) ? 1 : ((int)latestItemID + 1);

                lbl_ID.Text = newItemID.ToString();

                string insertQuery = @"
                INSERT INTO tbl_Items (Item_ID, Item_Name, Item_Price, Item_Details, Item_Expiration, Item_Icon, SubCategory_ID)
                VALUES (@ItemID, @ItemName, @ItemPrice, @ItemDetails, @ItemExpirationDate, @ItemIcon, (SELECT SubCategory_ID FROM tbl_SubCategories WHERE SubCategory_Name = @SelectedSubcategory))";

                using SqlCommand command = new(insertQuery, connection);

                command.Parameters.AddWithValue("@ItemID", newItemID);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@ItemPrice", itemPrice);
                command.Parameters.AddWithValue("@ItemDetails", (object)itemDetails ?? DBNull.Value);
                command.Parameters.AddWithValue("@ItemExpirationDate", itemExpirationDate);
                command.Parameters.AddWithValue("@ItemIcon", imageBytes);
                command.Parameters.AddWithValue("@SelectedSubcategory", selectedSubcategory);
                command.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");
            }
        }

        private static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using MemoryStream ms = new();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}