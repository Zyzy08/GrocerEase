using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=DESKTOP-BB2GC4I;Initial Catalog = db_GrocerEase; Integrated Security = True; Encrypt=False;";

        private void NewProduct_Load(object sender, EventArgs e)
        {

            // Fetch categories and populate cb_Category
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string queryCategories = "SELECT Category_Name FROM tbl_Categories";

                    using (SqlCommand commandCategories = new SqlCommand(queryCategories, connection))
                    {
                        using (SqlDataReader readerCategories = commandCategories.ExecuteReader())
                        {
                            while (readerCategories.Read())
                            {
                                string categoryName = readerCategories["Category_Name"].ToString();
                                cb_Category.Items.Add(categoryName);
                            }
                        }
                    }
                }
            }

            // Attach an event handler for cb_Category.SelectedIndexChanged
            cb_Category.SelectedIndexChanged += (cbCategorySender, cbCategoryEvent) =>
            {
                // Clear cb_SubCategory items when a new category is selected
                cb_SubCategory.Items.Clear();

                // Fetch subcategories based on the selected category
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        string selectedCategory = cb_Category.SelectedItem.ToString();
                        string querySubcategories = "SELECT SubCategory_Name FROM tbl_SubCategories WHERE Category_ID = (SELECT Category_ID FROM tbl_Categories WHERE Category_Name = @SelectedCategory)";

                        using (SqlCommand commandSubcategories = new SqlCommand(querySubcategories, connection))
                        {
                            commandSubcategories.Parameters.AddWithValue("@SelectedCategory", selectedCategory);

                            using (SqlDataReader readerSubcategories = commandSubcategories.ExecuteReader())
                            {
                                while (readerSubcategories.Read())
                                {
                                    string subcategoryName = readerSubcategories["SubCategory_Name"].ToString();
                                    cb_SubCategory.Items.Add(subcategoryName);
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}