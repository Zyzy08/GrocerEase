using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUserAuthentication
{
    public partial class frmAddUserAdmin : Form
    {
        public frmAddUserAdmin()
        {
            InitializeComponent();
        }

        private void AddUserAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllogin' table. You can move, or remove it, as needed.
            this.tblloginTableAdapter.Fill(this.appData.tbllogin);

        }

        private void Edit(bool value)
        { 
            txtUserName.Enabled = value;
            txtPassword.Enabled = value;
            cbRole.Enabled = value;
        }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllogin.AddtblloginRow(appData.tbllogin.NewtblloginRow());
                tblloginBindingSource.MoveLast();
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllogin.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtUserName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
               tblloginBindingSource.EndEdit();
                tblloginTableAdapter.Update(appData.tbllogin);
                dgvadminuser.Refresh();
                txtUserName.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllogin.RejectChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes);
            {
                tblloginBindingSource.RemoveCurrent();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblloginBindingSource.ResetBindings(false);
        }
    }
}
