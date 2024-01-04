using GrocerEase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayra
{
    public partial class Checkout : Form
    {
        private readonly decimal totalSale;

        public Checkout(decimal totalSale)
        {
            InitializeComponent();
            this.totalSale = totalSale;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            lbl_Total.Text = $"Total: ₱{totalSale:N2}";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Receipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new();
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
            decimal change = cashAmount - totalSale;

            if (change >= 0)
            {
                lbl_Change.Text = $"Change: ₱{change:N2}";
                btn_Receipt.Enabled = true;
            }
            else
            {
                lbl_Change.Text = "Insufficient cash";
                btn_Receipt.Enabled = false;
            }
        }
    }
}
