using Sayra;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class Receipt : Form
    {
        private readonly Label lbl_TotalPOS;
        private readonly Checkout checkoutForm;

        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public Receipt(Label lbl_TotalPOS, Checkout checkoutForm)
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            this.lbl_TotalPOS = lbl_TotalPOS;
            this.checkoutForm = checkoutForm;
        }

        public override bool Equals(object? obj)
        {
            return obj is Receipt receipt &&
                   EqualityComparer<Label>.Default.Equals(lbl_TotalPOS, receipt.lbl_TotalPOS);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            checkoutForm.Visible = true;
            this.Close();
        }
    }
}
