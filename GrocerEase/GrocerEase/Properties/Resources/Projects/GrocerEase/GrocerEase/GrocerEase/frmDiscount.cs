using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
        }


        public string SelectedDiscountType { get; private set; }
        public string SelectedPromotion { get; private set; }
        public string SelectedPaymentMode { get; private set; }

        private void cmbDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void cmbPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SelectedDiscountType = cmbDiscountType.SelectedItem.ToString();
            SelectedPromotion = cmbPromotionType.SelectedItem.ToString();
            SelectedPaymentMode = cmbPaymentMode.SelectedItem.ToString();

            this.Close();
        }
    }
}
