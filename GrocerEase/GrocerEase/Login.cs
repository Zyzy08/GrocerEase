namespace GrocerEase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
