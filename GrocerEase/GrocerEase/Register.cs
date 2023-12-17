using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        readonly SqlConnection connection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Moi\\Documents\\DBLogin.mdf;Integrated Security=True;Connect Timeout=30");
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fname.Text != "" && Lname.Text != "" && Mname.Text != "" && Bday.Text != "" && Email.Text != "" &&
                    Gender.Text != "" && Address.Text != "" && Password.Text != "" && ConPass.Text != "")
                {
                    if (Password.Text == ConPass.Text)
                    {
                        int v = Check(Email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new("insert into tbl_Registration values(@f_name,@l_name, @m_name" +
                                "@b_date, @gender, @Address, @email, @password)", connection);

                            command.Parameters.AddWithValue("@f_name", Fname.Text);
                            command.Parameters.AddWithValue("@l_name", Mname.Text);
                            command.Parameters.AddWithValue("@m_name", Lname.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(Bday.Text));
                            command.Parameters.AddWithValue("@gender", Gender.Text);
                            command.Parameters.AddWithValue("@address", Address.Text);
                            command.Parameters.AddWithValue("@email", Email.Text);
                            command.Parameters.AddWithValue("@password", Password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Register Successfully");
                            Fname.Text = "";
                            Mname.Text = "";
                            Lname.Text = "";
                            Address.Text = "";
                            Email.Text = "";
                            Gender.Text = "";
                            Bday.Text = "";
                            Password.Text = "";
                            ConPass.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You are already registered");

                        }
                    }
                    else

                    {
                        MessageBox.Show("Password does not match.");

                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int Check(string email)
        {
            connection.Open();
            string query = "select count(*) from tbl_Registration where email = '" + email + "'";
            SqlCommand command = new(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;

        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheck.Checked)
            {
                Password.UseSystemPasswordChar = false;
                ConPass.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                ConPass.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new();
            login.Show();
        }
    }
}
