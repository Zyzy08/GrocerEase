using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sayra
{
    public partial class CategoryDetail : Form
    {
        public CategoryDetail()
        {
            InitializeComponent();
        }

        public string Mode { get; set; }

        public int CategoryId { get; internal set; }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            string categoryName = tb_Name.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter a valid category name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection connection = new(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized."));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                if (Mode == "Add" && CategoryExists(connection, categoryName))
                {
                    MessageBox.Show("Category with the same name already exists.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;

                if (Mode == "Add")
                {
                    // Use the GetNextCategoryId function to get the smallest available Category_ID
                    int newCategoryId = GetNextCategoryId(connection);
                    query = "INSERT INTO tbl_Categories (Category_ID, Category_Name) VALUES (@CategoryId, @CategoryName)";
                }
                else
                {
                    query = "UPDATE tbl_Categories SET Category_Name = @CategoryName WHERE Category_ID = @CategoryId";
                }

                using SqlCommand command = new(query, connection);

                if (Mode == "Add")
                {
                    // Set the parameter value to the obtained new Category_ID
                    command.Parameters.AddWithValue("@CategoryId", GetNextCategoryId(connection));
                }
                else
                {
                    command.Parameters.AddWithValue("@CategoryId", CategoryId);
                }

                command.Parameters.AddWithValue("@CategoryName", categoryName);

                command.ExecuteNonQuery();

                MessageBox.Show("Category " + (Mode == "Add" ? "added" : "edited") + " successfully!");

                ResetForm();

                if (Mode == "Edit")
                {
                    this.Close();
                }
            }

            if (this.Owner is UI ui)
            {
                ui.Lbl_Categories_Click(sender, e);
                ui.RefreshCategoriesForm();
            }
        }

        public static int GetNextCategoryId(SqlConnection connection)
        {
            int newCategoryId = 1;

            // Check if the tbl_Categories table is empty
            string queryCountCategories = "SELECT COUNT(*) FROM tbl_Categories";
            using (SqlCommand commandCountCategories = new SqlCommand(queryCountCategories, connection))
            {
                int categoryCount = Convert.ToInt32(commandCountCategories.ExecuteScalar());

                if (categoryCount > 0)
                {
                    // If not empty, find the next available ID
                    string queryAllCategoryIds = "SELECT Category_ID FROM tbl_Categories";
                    using (SqlCommand commandAllCategoryIds = new SqlCommand(queryAllCategoryIds, connection))
                    using (SqlDataReader reader = commandAllCategoryIds.ExecuteReader())
                    {
                        HashSet<int> existingIds = new HashSet<int>();

                        while (reader.Read())
                        {
                            existingIds.Add(reader.GetInt32(0));
                        }

                        // Find the next available ID
                        while (existingIds.Contains(newCategoryId))
                        {
                            newCategoryId++;
                        }
                    }
                }
            }

            return newCategoryId;
        }

        private static bool CategoryExists(SqlConnection connection, string categoryName)
        {
            string query = "SELECT COUNT(*) FROM tbl_Categories WHERE LOWER(Category_Name) = LOWER(@CategoryName)";

            using (SqlCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryName", categoryName.ToLower());

                // ExecuteScalar without using SqlDataReader
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        private void ResetForm()
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();
                lbl_ID.Text = GetNextCategoryId(connection).ToString();
            }

            tb_Name.Text = string.Empty;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryDetail_Load(object sender, EventArgs e)
        {
            ResetForm();

            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    lbl_ID.Text = GetNextCategoryId(connection).ToString();
                }
            }

            if (Mode == "Edit")
            {
                LoadCategoryDataForEditing();
            }
        }

        private void LoadCategoryDataForEditing()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryCategoryDetails = "SELECT Category_Name FROM tbl_Categories WHERE Category_ID = @CategoryId";

                using SqlCommand commandCategoryDetails = new(queryCategoryDetails, connection);
                commandCategoryDetails.Parameters.AddWithValue("@CategoryId", CategoryId);

                using SqlDataReader readerCategoryDetails = commandCategoryDetails.ExecuteReader();

                if (readerCategoryDetails.Read())
                {
                    lbl_ID.Text = CategoryId.ToString();
                    tb_Name.Text = readerCategoryDetails["Category_Name"].ToString();
                }
            }
        }
    }
}
