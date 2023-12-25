namespace GrocerEase
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            this.Hide();
            settings.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Lbl_Products_Click(object sender, EventArgs e)
        {
            Products products = new();
            products.Show();
            this.Close();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }
    }
}
