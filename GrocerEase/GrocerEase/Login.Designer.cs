namespace GrocerEase
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            btn_Login = new Button();
            btn_Exit = new Button();
            panel1 = new Panel();
            lbl_Title = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 17.9999981F);
            label1.Location = new Point(148, 266);
            label1.Name = "label1";
            label1.Size = new Size(146, 39);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 17.9999981F);
            label2.Location = new Point(148, 328);
            label2.Name = "label2";
            label2.Size = new Size(135, 39);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Username.Location = new Point(299, 268);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(257, 39);
            tb_Username.TabIndex = 3;
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Password.Location = new Point(299, 330);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(257, 39);
            tb_Password.TabIndex = 4;
            tb_Password.KeyPress += Login_KeyPress;
            // 
            // btn_Login
            // 
            btn_Login.AutoSize = true;
            btn_Login.BackColor = Color.OliveDrab;
            btn_Login.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(336, 407);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(172, 54);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += Btn_Login_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(757, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(31, 33);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(lbl_Title);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 58);
            panel1.TabIndex = 7;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(12, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(776, 58);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "GrocerEase - Login";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1397, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 482);
            Controls.Add(panel1);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private Button btn_Login;
        private Button btn_Exit;
        private Panel panel1;
        private Button button1;
        private Label lbl_Title;
    }
}
