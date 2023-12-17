using frmAddAcount;

namespace GrocerEase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new();
            this.Hide();
            register.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new();
            this.Hide();
            dashboard.Show();
        }
    }
}
