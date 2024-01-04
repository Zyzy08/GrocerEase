﻿using GrocerEase;
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

        private void Tb_Cash_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tb_Cash.Text, out decimal cashAmount))
            {
                decimal change = cashAmount - totalSale;

                if (change >= 0)
                {
                    lbl_Change.Text = $"Change: ₱{change:N2}";
                }
                else
                {
                    lbl_Change.Text = "Insufficient cash";
                }
            }
            else
            {
                lbl_Change.Text = "Change: ₱0.00";
            }
        }

        private void Tb_Cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && tb_Cash.Text.Any(c => c == '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && tb_Cash.Text.Contains('.'))
            {
                int dotPosition = tb_Cash.Text.IndexOf('.');
                if (tb_Cash.Text.Length - dotPosition > 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
