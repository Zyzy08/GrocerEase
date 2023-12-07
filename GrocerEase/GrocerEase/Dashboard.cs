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
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Int32 tabPage_count = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if(connection.State == ConnectionState.Open)
            {
                string sql = "SELECT COUNT(*) FROM tbl_Categories";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    tabPage_count = (Int32)cmd.ExecuteScalar();
                }
                for(int counter = 0; counter != tabPage_count; counter++) 
                {
                    string query = "SELECT Category_Name FROM tbl_Categories WHERE Category_ID=@tabPage";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("tabPage", tabPage_count);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        TabPage tabPage = new TabPage();
                        tabPage.Name = reader["Category_Name"].ToString();
                        tabPage.Text = reader["Category_Name"].ToString();
                        Dashboard_tcCategory.TabPages.Add(tabPage);
                    }
                }
                connection.Close();
            }
        }
    }
}