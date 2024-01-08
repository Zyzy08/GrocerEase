using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            dgv_Users.SelectionChanged += Dgv_Users_SelectionChanged;
            tb_Search.TextChanged += Tb_Search_TextChanged;

            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                // Adjusted query based on the provided column names
                string fetchUsersQuery = "SELECT Employee_ID as ID, " +
                                         "CONCAT(Employee_LastName, ', ', Employee_FirstName) as Name, " +
                                         "Employee_Role as Role, " +
                                         "Employee_Username as Username, " +
                                         "Employee_Password as Password " +
                                         "FROM tbl_Users";

                SqlCommand fetchCommand = new(fetchUsersQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Users = new();
                adapter.Fill(dt_Users);
                dgv_Users.DataSource = dt_Users;
            }
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            FilterUsers(tb_Search.Text);
        }

        private void Dgv_Users_SelectionChanged(object sender, EventArgs e)
        {
            btn_Edit.Enabled = dgv_Users.SelectedRows.Count == 1;
            btn_Remove.Enabled = dgv_Users.SelectedRows.Count > 0;
        }

        private void FilterUsers(string searchText)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchUsersQuery = "SELECT Employee_ID as ID, " +
                                         "CONCAT(Employee_LastName, ', ', Employee_FirstName) as Name, " +
                                         "Employee_Role as Role, " +
                                         "Employee_Username as Username, " +
                                         "Employee_Password as Password " +
                                         "FROM tbl_Users " +
                                         "WHERE CONCAT(Employee_LastName, ', ', Employee_FirstName) LIKE @SearchText";

                SqlCommand fetchCommand = new(fetchUsersQuery, connection);
                fetchCommand.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Users = new();
                adapter.Fill(dt_Users);
                dgv_Users.DataSource = dt_Users;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            /*using UserDetail userDetail = new();
            userDetail.Mode = "Add";
            userDetail.lbl_ID.Text = UserDetail.GetNextUserId().ToString();
            userDetail.Owner = this.ParentForm;
            userDetail.ShowDialog();*/
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Users.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected user/users?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using SqlConnection connection = new(DatabaseManager.ConnectionString);
                    connection.Open();

                    foreach (DataGridViewRow selectedRow in dgv_Users.SelectedRows)
                    {
                        int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                        string removeUserQuery = "DELETE FROM tbl_Users WHERE Employee_ID = @EmployeeID";
                        using SqlCommand removeUserCommand = new(removeUserQuery, connection);
                        removeUserCommand.Parameters.AddWithValue("@EmployeeID", userId);
                        removeUserCommand.ExecuteNonQuery();
                    }

                    RefreshData();
                }
            }
        }

        public void RefreshData()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string fetchUsersQuery = "SELECT Employee_ID as ID, " +
                                 "CONCAT(Employee_LastName, ', ', Employee_FirstName) as Name, " +
                                 "Employee_Role as Role, " +
                                 "Employee_Username as Username, " +
                                 "Employee_Password as Password " +
                                 "FROM tbl_Users";

                SqlCommand fetchCommand = new(fetchUsersQuery, connection);
                SqlDataAdapter adapter = new(fetchCommand);
                DataTable dt_Users = new();
                adapter.Fill(dt_Users);
                dgv_Users.DataSource = dt_Users;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Users.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_Users.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dgv_Users.Rows[selectedRowIndex].Cells["ID"].Value);

                /*using UserDetail userDetailForm = new();
                userDetailForm.Mode = "Edit";
                userDetailForm.UserId = userId;
                userDetailForm.Owner = this.ParentForm;
                userDetailForm.ShowDialog();*/

                RefreshData();
            }
        }
    }
}
