﻿using GrocerEase;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sayra
{
    public partial class Checkout : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static partial IntPtr CreateRoundRectRgn(int left, int right, int top, int bottom, int width, int height);

        private readonly Label lbl_TotalPOS;

        public Checkout(Label lbl_TotalPOS)
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            this.lbl_TotalPOS = lbl_TotalPOS;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            lbl_Total.Text = lbl_TotalPOS.Text;
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
            decimal change = cashAmount - Convert.ToDecimal(lbl_Total.Text);

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
