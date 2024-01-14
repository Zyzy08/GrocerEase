using GrocerEase;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sayra
{
    public partial class Checkout : Form
    {
        private readonly Label lbl_SubtotalPOS;
        private readonly Label lbl_VATPOS;
        private readonly Label lbl_DiscountsPOS;
        private readonly Label lbl_TotalPOS;
        private readonly int cashierID;
        private readonly Login.EmployeeData employeeData;
        public bool IsCompleted;

        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        public Checkout(Login.EmployeeData employeeData, Label lbl_SubtotalPOS, Label lbl_VATPOS, Label lbl_DiscountsPOS, Label lbl_TotalPOS, int cashierID)
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            this.employeeData = employeeData;
            this.lbl_SubtotalPOS = lbl_SubtotalPOS;
            this.lbl_VATPOS = lbl_VATPOS;
            this.lbl_DiscountsPOS = lbl_DiscountsPOS;
            this.lbl_TotalPOS = lbl_TotalPOS;
            this.cashierID = cashierID;

            UpdateTotal();
        }

        public string SubtotalText
        {
            get { return lbl_SubtotalPOS.Text; }
        }

        public string VATText
        {
            get { return lbl_VATPOS.Text; }
        }

        public string DiscountsText
        {
            get { return lbl_DiscountsPOS.Text; }
        }

        private void UpdateTotal()
        {
            lbl_Total.Text = lbl_TotalPOS.Text;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (IsCompleted == true)
            {
                if (this.Owner is UI ui)
                {
                    ui.Lbl_POS_Click(sender, e);
                }
            }
            this.Close();
        }

        private void Btn_Receipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new(lbl_TotalPOS, this, SubtotalText, VATText, DiscountsText, lbl_Total.Text, nud_Cash.Value.ToString(), lbl_Change.Text, cashierID)
            {
                Owner = this
            };
            this.Hide();
            receipt.ShowDialog();
        }

        private void Nud_Cash_ValueChanged(object sender, EventArgs e)
        {
            UpdateChangeLabel();
        }

        private void UpdateChangeLabel()
        {
            decimal currentValue = nud_Cash.Value;

            nud_Cash.Value = currentValue;

            decimal cashAmount = nud_Cash.Value;
            decimal change = cashAmount - Convert.ToDecimal(lbl_Total.Text);

            if (change >= 0)
            {
                lbl_Change_Label.Text = "Change: ₱";
                lbl_Change.Text = $"{change:N2}";
                btn_Checkout.Enabled = true;
            }
            else
            {
                lbl_Change_Label.Text = "Insufficient cash";
                lbl_Change.Text = "";
                btn_Checkout.Enabled = false;
            }
        }

        public void Checkout_Load(object sender, EventArgs e)
        {
            if(IsCompleted == true)
            {
                Btn_Cancel_Click(sender, e);
            }
        }
    }
}
