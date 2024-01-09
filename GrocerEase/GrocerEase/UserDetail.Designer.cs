namespace Sayra
{
    partial class UserDetail
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
            btn_Done = new Button();
            btn_Cancel = new Button();
            cb_Role = new ComboBox();
            tb_LastName = new TextBox();
            tb_FirstName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            lbl_ID = new Label();
            label10 = new Label();
            lbl_Title = new Label();
            label13 = new Label();
            pnl_Title = new Panel();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            label1 = new Label();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Done
            // 
            btn_Done.AutoSize = true;
            btn_Done.BackColor = Color.OliveDrab;
            btn_Done.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Done.ForeColor = Color.White;
            btn_Done.Location = new Point(209, 348);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new Size(117, 44);
            btn_Done.TabIndex = 87;
            btn_Done.Text = "DONE";
            btn_Done.UseVisualStyleBackColor = false;
            btn_Done.Click += Btn_Done_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 348);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(117, 44);
            btn_Cancel.TabIndex = 86;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // cb_Role
            // 
            cb_Role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Role.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Role.FormattingEnabled = true;
            cb_Role.Items.AddRange(new object[] { "Admin", "Cashier" });
            cb_Role.Location = new Point(143, 206);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(183, 33);
            cb_Role.TabIndex = 84;
            cb_Role.SelectedIndexChanged += Cb_Role_SelectedIndexChanged;
            // 
            // tb_LastName
            // 
            tb_LastName.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_LastName.Location = new Point(143, 158);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(183, 29);
            tb_LastName.TabIndex = 81;
            tb_LastName.TextChanged += Tb_LastName_TextChanged;
            // 
            // tb_FirstName
            // 
            tb_FirstName.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_FirstName.Location = new Point(143, 105);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(183, 29);
            tb_FirstName.TabIndex = 80;
            tb_FirstName.TextChanged += Tb_FirstName_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comfortaa", 14.25F);
            label12.Location = new Point(11, 209);
            label12.Name = "label12";
            label12.Size = new Size(58, 30);
            label12.TabIndex = 76;
            label12.Text = "Role:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comfortaa", 14.25F);
            label11.Location = new Point(11, 157);
            label11.Name = "label11";
            label11.Size = new Size(125, 30);
            label11.TabIndex = 75;
            label11.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 14.25F);
            label4.Location = new Point(11, 62);
            label4.Name = "label4";
            label4.Size = new Size(37, 30);
            label4.TabIndex = 71;
            label4.Text = "ID:";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Comfortaa", 14.25F);
            lbl_ID.Location = new Point(79, 62);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 30);
            lbl_ID.TabIndex = 74;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comfortaa", 14.25F);
            label10.Location = new Point(11, 104);
            label10.Name = "label10";
            label10.Size = new Size(126, 30);
            label10.TabIndex = 73;
            label10.Text = "First Name:";
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(11, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(315, 48);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "Add a new user";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comfortaa", 14.25F);
            label13.Location = new Point(11, 257);
            label13.Name = "label13";
            label13.Size = new Size(120, 30);
            label13.TabIndex = 77;
            label13.Text = "Username:";
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.OliveDrab;
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Margin = new Padding(3, 2, 3, 2);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(340, 51);
            pnl_Title.TabIndex = 72;
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Username.Location = new Point(143, 257);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(183, 29);
            tb_Username.TabIndex = 88;
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Password.Location = new Point(143, 303);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(183, 29);
            tb_Password.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 14.25F);
            label1.Location = new Point(11, 303);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 90;
            label1.Text = "Password:";
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(338, 401);
            Controls.Add(label1);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(btn_Done);
            Controls.Add(btn_Cancel);
            Controls.Add(cb_Role);
            Controls.Add(tb_LastName);
            Controls.Add(tb_FirstName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(lbl_ID);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDetail";
            Load += UserDetail_Load;
            pnl_Title.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Done;
        private Button btn_Cancel;
        private Label label12;
        private Label label11;
        private Label label4;
        public Label lbl_ID;
        private Label label10;
        private Label lbl_Title;
        private Label label13;
        private Panel pnl_Title;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private Label label1;
        public ComboBox cb_Role;
        public TextBox tb_LastName;
        public TextBox tb_FirstName;
    }
}