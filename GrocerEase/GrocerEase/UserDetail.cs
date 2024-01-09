using GrocerEase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sayra
{
    public partial class UserDetail : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public UserDetail()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        public string Mode { get; set; }

        public int UserId { get; internal set; }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            string firstName = tb_FirstName.Text.Trim();
            string lastName = tb_LastName.Text.Trim();
            string role = cb_Role.SelectedItem.ToString();
            string userName = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter valid user details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SqlConnection connection = new(DatabaseManager.ConnectionString ?? throw new InvalidOperationException("Connection string is not initialized."));
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string query;

                if (Mode == "Add")
                {
                    int newUserId = GetNextUserId(connection);
                    query = "INSERT INTO tbl_Users (Employee_ID, Employee_FirstName, Employee_LastName, Employee_Role, Employee_Username, Employee_Password) VALUES (@EmployeeId, @FirstName, @LastName, @Role, @UserName, @Password)";
                }
                else
                {
                    query = "UPDATE tbl_Users SET Employee_FirstName = @FirstName, Employee_LastName = @LastName, Employee_Role = @Role, Employee_Username = @UserName, Employee_Password = @Password WHERE Employee_ID = @EmployeeId";
                }

                using SqlCommand command = new(query, connection);

                if (Mode == "Add")
                {
                    command.Parameters.AddWithValue("@EmployeeId", GetNextUserId(connection));
                }
                else
                {
                    command.Parameters.AddWithValue("@EmployeeId", UserId);
                }

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                command.ExecuteNonQuery();

                MessageBox.Show("User " + (Mode == "Add" ? "added" : "edited") + " successfully!");

                ResetForm();

                if (Mode == "Edit")
                {
                    this.Close();
                }
            }

            if (this.Owner is UI ui)
            {
                ui.RefreshUsersForm();
            }
        }

        public static int GetNextUserId(SqlConnection connection)
        {
            int newUserId = 1;

            string queryCountUsers = "SELECT COUNT(*) FROM tbl_Users";
            using (SqlCommand commandCountUsers = new(queryCountUsers, connection))
            {
                int userCount = Convert.ToInt32(commandCountUsers.ExecuteScalar());

                if (userCount > 0)
                {
                    string queryAllUserIds = "SELECT Employee_ID FROM tbl_Users";
                    using SqlCommand commandAllUserIds = new(queryAllUserIds, connection);
                    using SqlDataReader reader = commandAllUserIds.ExecuteReader();
                    HashSet<int> existingIds = [];

                    while (reader.Read())
                    {
                        existingIds.Add(reader.GetInt32(0));
                    }

                    while (existingIds.Contains(newUserId))
                    {
                        newUserId++;
                    }
                }
            }

            return newUserId;
        }

        private void ResetForm()
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();
                lbl_ID.Text = GetNextUserId(connection).ToString();
            }

            tb_FirstName.Text = string.Empty;
            tb_LastName.Text = string.Empty;
            cb_Role.SelectedIndex = 0;
            tb_Username.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            ResetForm();

            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    int nextEmployeeId = GetNextUserId(connection);

                    string formattedEmployeeID = nextEmployeeId.ToString("D3");
                    lbl_ID.Text = formattedEmployeeID;
                }
            }

            if (Mode == "Edit")
            {
                lbl_Title.Text = "Edit a user";
                pnl_Title.BackColor = Color.SteelBlue;
                this.BackColor = Color.AliceBlue;

                LoadUserDataForEditing();
            }
        }

        private void LoadUserDataForEditing()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryUserDetails = "SELECT Employee_ID, Employee_FirstName, Employee_LastName, Employee_Role, Employee_Username, Employee_Password FROM tbl_Users WHERE Employee_ID = @EmployeeId";

                using SqlCommand commandUserDetails = new(queryUserDetails, connection);
                commandUserDetails.Parameters.AddWithValue("@EmployeeId", UserId);

                using SqlDataReader readerUserDetails = commandUserDetails.ExecuteReader();

                if (readerUserDetails.Read())
                {
                    lbl_ID.Text = readerUserDetails["Employee_ID"].ToString();
                    tb_FirstName.Text = readerUserDetails["Employee_FirstName"].ToString();
                    tb_LastName.Text = readerUserDetails["Employee_LastName"].ToString();
                    cb_Role.SelectedItem = readerUserDetails["Employee_Role"].ToString();
                    tb_Username.Text = readerUserDetails["Employee_Username"].ToString();
                    tb_Password.Text = readerUserDetails["Employee_Password"].ToString();
                }
            }
        }

        private void Tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            AutoFillCredentials();
        }

        private void Tb_LastName_TextChanged(object sender, EventArgs e)
        {
            AutoFillCredentials();
        }

        private void Cb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillCredentials();
        }

        private void AutoFillCredentials()
        {
            string lastName = tb_LastName.Text.Trim();
            string firstName = tb_FirstName.Text.Trim();

            if (!string.IsNullOrEmpty(firstName))
            {
                firstName = char.ToUpper(firstName[0]) + firstName[1..];
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                lastName = char.ToUpper(lastName[0]) + lastName[1..];
            }

            tb_Username.Text = $"{lastName}{(firstName.Length > 0 ? firstName[0] : ' ')}{lbl_ID.Text}";

            string role = cb_Role.SelectedItem.ToString().ToLower();

            tb_Password.Text = role;
        }
    }
}
