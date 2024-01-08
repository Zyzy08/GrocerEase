using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frmUserAuthentication
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.auDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllogin WHERE Username='"+txtusername.Text+"' and Password='"+ txtpassword.Text+"'",con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i == 1)
            {
                frmHome fhm = new frmHome();
                fhm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your username or password","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
                
            
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
 