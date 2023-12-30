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

        public string Mode { get; internal set; } = "Add";

        public int CategoryId { get; internal set; }

        public Action RefreshCategoriesList { get; set; }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            string categoryName = tb_Name.Text;

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter a valid category name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                if (Mode == "Add")
                {
                    CategoryId = GetNextCategoryId(connection);
                }

                string query;

                if (Mode == "Add")
                {
                    query = "INSERT INTO tbl_Categories (Category_ID, Category_Name) VALUES (@CategoryId, @CategoryName)";
                }
                else
                {
                    query = "UPDATE tbl_Categories SET Category_Name = @CategoryName WHERE Category_ID = @CategoryId";
                }

                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@CategoryId", CategoryId);
                command.Parameters.AddWithValue("@CategoryName", categoryName);

                command.ExecuteNonQuery();

                MessageBox.Show("Category " + (Mode == "Add" ? "added" : "edited") + " successfully!");

                RefreshCategoriesList?.Invoke();

                if (Mode == "Edit")
                {
                    this.Close();
                }

                ResetForm();

                if (this.Owner is UI ui)
                {
                    ui.RefreshCategoriesForm();
                }
            }
        }

        private void ResetForm()
        {
            tb_Name.Text = string.Empty;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryDetail_Load(object sender, EventArgs e)
        {
            if (Mode == "Add")
            {
                SetNextCategoryId();
            }

            ResetForm();

            if (Mode == "Edit")
            {
                LoadCategoryDataForEditing();
            }
        }

        private void SetNextCategoryId()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                lbl_ID.Text = GetNextCategoryId(connection).ToString();
            }
        }

        private static int GetNextCategoryId(SqlConnection connection)
        {
            string queryMinCategoryId = "SELECT MIN(Category_ID) + 1 FROM tbl_Categories WHERE NOT EXISTS (SELECT 1 FROM tbl_Categories AS t2 WHERE t2.Category_ID = tbl_Categories.Category_ID + 1)";

            using SqlCommand commandMinCategoryId = new(queryMinCategoryId, connection);
            object minCategoryId = commandMinCategoryId.ExecuteScalar();

            return minCategoryId != null && minCategoryId != DBNull.Value ? Convert.ToInt32(minCategoryId) : 1;
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
                    tb_Name.Text = readerCategoryDetails["Category_Name"].ToString();
                }
            }
        }
    }
}
