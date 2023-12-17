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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new();
            dashboard.Show();
            this.Close();
        }

        private void StockManagement_btn_Add_Click(object sender, EventArgs e)
        {
            NewProduct newProductForm = new(this);
            newProductForm.ShowDialog();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
