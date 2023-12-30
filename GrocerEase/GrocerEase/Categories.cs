using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            dgv_Categories.DefaultCellStyle.Font = new Font("Comforta", 10, FontStyle.Regular);
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchCategoriesQuery = "SELECT Category_ID as ID, Category_Name as Name, ISNULL(InStock, 0) as [In-Stock] FROM tbl_Categories";

                SqlCommand fetchCommand = new(fetchCategoriesQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Categories = new();
                adapter.Fill(dt_Categories);
                dgv_Categories.DataSource = dt_Categories;
            }

            connection.Close();
        }
    }
}
