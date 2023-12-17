namespace GrocerEase
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Fname = new TextBox();
            Lname = new TextBox();
            Mname = new TextBox();
            Address = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            ConPass = new TextBox();
            Bday = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            Gender = new ComboBox();
            panel1 = new Panel();
            cbxCheck = new CheckBox();
            btnRegister = new Button();
            btn_Login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 42);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 144);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 206);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 100);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 162);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 224);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 284);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 7;
            label8.Text = "Confirm Password:";
            // 
            // Fname
            // 
            Fname.Location = new Point(34, 106);
            Fname.Name = "Fname";
            Fname.Size = new Size(220, 26);
            Fname.TabIndex = 8;
            // 
            // Lname
            // 
            Lname.Location = new Point(34, 167);
            Lname.Name = "Lname";
            Lname.Size = new Size(220, 26);
            Lname.TabIndex = 9;
            // 
            // Mname
            // 
            Mname.Location = new Point(34, 230);
            Mname.Name = "Mname";
            Mname.Size = new Size(220, 26);
            Mname.TabIndex = 10;
            // 
            // Address
            // 
            Address.Location = new Point(386, 124);
            Address.Name = "Address";
            Address.Size = new Size(272, 26);
            Address.TabIndex = 11;
            // 
            // Email
            // 
            Email.Location = new Point(386, 190);
            Email.Name = "Email";
            Email.Size = new Size(272, 26);
            Email.TabIndex = 12;
            // 
            // Password
            // 
            Password.Location = new Point(386, 248);
            Password.Name = "Password";
            Password.Size = new Size(272, 26);
            Password.TabIndex = 13;
            // 
            // ConPass
            // 
            ConPass.Location = new Point(386, 308);
            ConPass.Name = "ConPass";
            ConPass.Size = new Size(272, 26);
            ConPass.TabIndex = 14;
            ConPass.UseSystemPasswordChar = true;
            // 
            // Bday
            // 
            Bday.Location = new Point(38, 306);
            Bday.Name = "Bday";
            Bday.Size = new Size(278, 26);
            Bday.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 282);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 16;
            label9.Text = "Birthday:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 351);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 17;
            label10.Text = "Gender:";
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Female", "Male" });
            Gender.Location = new Point(38, 375);
            Gender.Name = "Gender";
            Gender.Size = new Size(193, 28);
            Gender.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(cbxCheck);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(Gender);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(Bday);
            panel1.Controls.Add(ConPass);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Address);
            panel1.Controls.Add(Mname);
            panel1.Controls.Add(Lname);
            panel1.Controls.Add(Fname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(13, 37);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 498);
            panel1.TabIndex = 0;
            // 
            // cbxCheck
            // 
            cbxCheck.AutoSize = true;
            cbxCheck.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCheck.Location = new Point(386, 340);
            cbxCheck.Name = "cbxCheck";
            cbxCheck.Size = new Size(102, 17);
            cbxCheck.TabIndex = 21;
            cbxCheck.Text = "Show Password";
            cbxCheck.UseVisualStyleBackColor = true;
            cbxCheck.CheckedChanged += check_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gainsboro;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(386, 375);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 38);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Gainsboro;
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(543, 375);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(151, 38);
            btn_Login.TabIndex = 22;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(773, 589);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Register";
            Text = "ADMIN - Add Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConPass;
        private System.Windows.Forms.DateTimePicker Bday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox cbxCheck;
        private Button btn_Login;
    }
}