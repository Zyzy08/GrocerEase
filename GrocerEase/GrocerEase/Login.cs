using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace GrocerEase
{
    public partial class Login : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public Login()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            DatabaseManager.Initialize("Data Source=DESKTOP-BB2GC4I;Initial Catalog=db_GrocerEase;Integrated Security=True;Encrypt=False;");
            
            this.KeyPress += Login_KeyPress;
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Login_Click(sender, e);
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();

            if (AuthenticateUser(username, password, out var employeeData))
            {
                UI ui = new(employeeData);
                this.Hide();
                ui.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out EmployeeData? employeeData)
        {
            employeeData = null;

            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            string query = "SELECT * FROM tbl_Users WHERE Employee_Username = @Username AND Employee_Password = @Password";

            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                employeeData = new EmployeeData
                {
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("Employee_ID")),
                    FirstName = reader.GetString(reader.GetOrdinal("Employee_FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("Employee_LastName")),
                    Role = reader.GetString(reader.GetOrdinal("Employee_Role")),
                    Username = reader.GetString(reader.GetOrdinal("Employee_Username")),
                    Password = reader.GetString(reader.GetOrdinal("Employee_Password"))
                };

                return true;
            }

            return false;
        }

        public class EmployeeData
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Role { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
