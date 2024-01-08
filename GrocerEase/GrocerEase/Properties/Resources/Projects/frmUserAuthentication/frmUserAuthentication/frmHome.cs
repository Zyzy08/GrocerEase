using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUserAuthentication
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnAddUserAdmin_Click(object sender, EventArgs e)
        {
          frmAddUserAdmin frmAddUserAdmin = new frmAddUserAdmin();
            frmAddUserAdmin.ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }
    }
}
