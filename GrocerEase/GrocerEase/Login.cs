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
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            UI ui = new();
            this.Hide();
            ui.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
