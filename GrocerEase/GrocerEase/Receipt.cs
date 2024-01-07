using Sayra;
using System;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class Receipt : Form
    {
        private readonly Label lbl_TotalPOS;
        private readonly Checkout checkoutForm;

        public Receipt(Label lbl_TotalPOS, Checkout checkoutForm)
        {
            InitializeComponent();

            this.lbl_TotalPOS = lbl_TotalPOS;
            this.checkoutForm = checkoutForm;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            checkoutForm.Visible = true;
            this.Close();
        }
    }
}
