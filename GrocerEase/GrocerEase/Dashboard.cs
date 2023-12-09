using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrocerEase
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=DESKTOP-BB2GC4I;Initial Catalog = db_GrocerEase; Integrated Security = True; Encrypt=False;";
        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            this.Hide();
            settings.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            if(connection.State == ConnectionState.Open)
            {
                string query_categories_count = "SELECT COUNT(*) FROM tbl_Categories";
                SqlCommand command_categories_count = new(query_categories_count, connection);
                int categories_tabPage_count = (Int32)command_categories_count.ExecuteScalar();
                SqlDataReader reader_categories;
                for(int counter = 1; counter <= categories_tabPage_count; counter++)
                {
                    string query_categories = "SELECT Category_Name FROM tbl_Categories WHERE Category_ID=@tabPage";
                    SqlCommand command_categories = new(query_categories, connection);
                    command_categories.Parameters.AddWithValue("tabPage", counter);
                    reader_categories = command_categories.ExecuteReader();
                    if(reader_categories.Read())
                    {
                        TabPage tabPage_Category = new()
                        {
                            Name = "Category" + counter,
                            Text = reader_categories["Category_Name"].ToString()
                        };
                        TabControl subcategoryTabControl = new();
                        string query_subcategories = "SELECT SubCategory_Name FROM tbl_SubCategories WHERE Category_ID=@categoryID";
                        SqlCommand command_subcategories = new(query_subcategories, connection);
                        command_subcategories.Parameters.AddWithValue("categoryID", counter);
                        reader_categories.Close();
                        SqlDataReader reader_subcategories = command_subcategories.ExecuteReader();
                        while (reader_subcategories.Read())
                        {
                            TabPage tabPage_Subcategory = new()
                            {
                                Name = "Subcategory" + counter,
                                Text = reader_subcategories["SubCategory_Name"].ToString()
                            };
                            subcategoryTabControl.TabPages.Add(tabPage_Subcategory);
                        }
                        reader_subcategories.Close();
                        tabPage_Category.Controls.Add(subcategoryTabControl);
                        Dashboard_tcCategory.TabPages.Add(tabPage_Category);
                    }
                }
                connection.Close();
            }
        }
    }
}