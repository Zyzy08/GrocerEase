namespace GrocerEase
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_Exit = new Button();
            pnl_Content = new Panel();
            panel4 = new Panel();
            flp_Tabs = new FlowLayoutPanel();
            lbl_Dashboard = new Label();
            label6 = new Label();
            lbl_Products = new Label();
            label7 = new Label();
            lbl_Categories = new Label();
            label8 = new Label();
            lbl_Discounts = new Label();
            label9 = new Label();
            lbl_Users = new Label();
            label10 = new Label();
            label12 = new Label();
            lbl_POS = new Label();
            label13 = new Label();
            label14 = new Label();
            lbl_Logout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            flp_Tabs.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btn_Exit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 58);
            panel1.TabIndex = 4;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Exit.BackColor = Color.Tomato;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.White;
            btn_Exit.Location = new Point(1397, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(31, 33);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // pnl_Content
            // 
            pnl_Content.BorderStyle = BorderStyle.FixedSingle;
            pnl_Content.Location = new Point(111, 64);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(1317, 784);
            pnl_Content.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(flp_Tabs);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(122, 784);
            panel4.TabIndex = 7;
            // 
            // flp_Tabs
            // 
            flp_Tabs.Controls.Add(lbl_Dashboard);
            flp_Tabs.Controls.Add(label6);
            flp_Tabs.Controls.Add(lbl_Products);
            flp_Tabs.Controls.Add(label7);
            flp_Tabs.Controls.Add(lbl_Categories);
            flp_Tabs.Controls.Add(label8);
            flp_Tabs.Controls.Add(lbl_Discounts);
            flp_Tabs.Controls.Add(label9);
            flp_Tabs.Controls.Add(lbl_Users);
            flp_Tabs.Controls.Add(label10);
            flp_Tabs.Controls.Add(label12);
            flp_Tabs.Controls.Add(lbl_POS);
            flp_Tabs.Controls.Add(label13);
            flp_Tabs.Controls.Add(label14);
            flp_Tabs.Controls.Add(lbl_Logout);
            flp_Tabs.FlowDirection = FlowDirection.TopDown;
            flp_Tabs.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flp_Tabs.Location = new Point(-3, 88);
            flp_Tabs.Name = "flp_Tabs";
            flp_Tabs.Size = new Size(124, 630);
            flp_Tabs.TabIndex = 4;
            // 
            // lbl_Dashboard
            // 
            lbl_Dashboard.BackColor = SystemColors.Control;
            lbl_Dashboard.BorderStyle = BorderStyle.FixedSingle;
            lbl_Dashboard.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_Dashboard.ForeColor = Color.SandyBrown;
            lbl_Dashboard.Location = new Point(3, 0);
            lbl_Dashboard.Name = "lbl_Dashboard";
            lbl_Dashboard.Size = new Size(119, 38);
            lbl_Dashboard.TabIndex = 0;
            lbl_Dashboard.Tag = "Tab";
            lbl_Dashboard.Text = " Dashboard";
            lbl_Dashboard.Click += Lbl_Dashboard_Click;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 38);
            label6.Name = "label6";
            label6.Size = new Size(154, 38);
            label6.TabIndex = 1;
            // 
            // lbl_Products
            // 
            lbl_Products.BackColor = SystemColors.Control;
            lbl_Products.BorderStyle = BorderStyle.FixedSingle;
            lbl_Products.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_Products.ForeColor = Color.SandyBrown;
            lbl_Products.Location = new Point(3, 76);
            lbl_Products.Name = "lbl_Products";
            lbl_Products.Size = new Size(119, 38);
            lbl_Products.TabIndex = 1;
            lbl_Products.Tag = "Tab";
            lbl_Products.Text = "Products";
            lbl_Products.TextAlign = ContentAlignment.TopCenter;
            lbl_Products.Click += Lbl_Products_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 114);
            label7.Name = "label7";
            label7.Size = new Size(154, 38);
            label7.TabIndex = 2;
            // 
            // lbl_Categories
            // 
            lbl_Categories.BackColor = SystemColors.Control;
            lbl_Categories.BorderStyle = BorderStyle.FixedSingle;
            lbl_Categories.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_Categories.ForeColor = Color.SandyBrown;
            lbl_Categories.Location = new Point(3, 152);
            lbl_Categories.Name = "lbl_Categories";
            lbl_Categories.Size = new Size(119, 38);
            lbl_Categories.TabIndex = 2;
            lbl_Categories.Tag = "Tab";
            lbl_Categories.Text = "Categories";
            lbl_Categories.TextAlign = ContentAlignment.TopCenter;
            lbl_Categories.Click += Lbl_Categories_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 190);
            label8.Name = "label8";
            label8.Size = new Size(154, 38);
            label8.TabIndex = 3;
            // 
            // lbl_Discounts
            // 
            lbl_Discounts.BackColor = SystemColors.Control;
            lbl_Discounts.BorderStyle = BorderStyle.FixedSingle;
            lbl_Discounts.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_Discounts.ForeColor = Color.SandyBrown;
            lbl_Discounts.Location = new Point(3, 228);
            lbl_Discounts.Name = "lbl_Discounts";
            lbl_Discounts.Size = new Size(119, 38);
            lbl_Discounts.TabIndex = 11;
            lbl_Discounts.Tag = "Tab";
            lbl_Discounts.Text = "Discounts";
            lbl_Discounts.TextAlign = ContentAlignment.TopCenter;
            lbl_Discounts.Click += Lbl_Discounts_Click;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 266);
            label9.Name = "label9";
            label9.Size = new Size(154, 38);
            label9.TabIndex = 4;
            // 
            // lbl_Users
            // 
            lbl_Users.BackColor = SystemColors.Control;
            lbl_Users.BorderStyle = BorderStyle.FixedSingle;
            lbl_Users.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_Users.ForeColor = Color.SandyBrown;
            lbl_Users.Location = new Point(3, 304);
            lbl_Users.Name = "lbl_Users";
            lbl_Users.Size = new Size(119, 38);
            lbl_Users.TabIndex = 3;
            lbl_Users.Tag = "Tab";
            lbl_Users.Text = "Users";
            lbl_Users.TextAlign = ContentAlignment.TopCenter;
            lbl_Users.Click += Lbl_Users_Click;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 342);
            label10.Name = "label10";
            label10.Size = new Size(154, 38);
            label10.TabIndex = 5;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 380);
            label12.Name = "label12";
            label12.Size = new Size(154, 38);
            label12.TabIndex = 7;
            // 
            // lbl_POS
            // 
            lbl_POS.BackColor = SystemColors.Control;
            lbl_POS.BorderStyle = BorderStyle.FixedSingle;
            lbl_POS.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold);
            lbl_POS.ForeColor = Color.SandyBrown;
            lbl_POS.Location = new Point(3, 418);
            lbl_POS.Name = "lbl_POS";
            lbl_POS.Size = new Size(121, 38);
            lbl_POS.TabIndex = 6;
            lbl_POS.Tag = "Tab";
            lbl_POS.Text = "POS";
            lbl_POS.TextAlign = ContentAlignment.TopCenter;
            lbl_POS.Click += Lbl_POS_Click;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 456);
            label13.Name = "label13";
            label13.Size = new Size(154, 38);
            label13.TabIndex = 8;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 494);
            label14.Name = "label14";
            label14.Size = new Size(154, 38);
            label14.TabIndex = 9;
            // 
            // lbl_Logout
            // 
            lbl_Logout.BackColor = SystemColors.Control;
            lbl_Logout.BorderStyle = BorderStyle.FixedSingle;
            lbl_Logout.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Logout.ForeColor = Color.SandyBrown;
            lbl_Logout.Location = new Point(3, 532);
            lbl_Logout.Name = "lbl_Logout";
            lbl_Logout.Size = new Size(119, 38);
            lbl_Logout.TabIndex = 10;
            lbl_Logout.Tag = "Tab";
            lbl_Logout.Text = "Logout";
            lbl_Logout.TextAlign = ContentAlignment.TopCenter;
            lbl_Logout.Click += Lbl_Logout_Click;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 860);
            Controls.Add(pnl_Content);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += UI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            flp_Tabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pnl_Content;
        private Panel panel4;
        private Label lbl_Dashboard;
        private Button btn_Exit;
        private Label lbl_Categories;
        private FlowLayoutPanel flp_Tabs;
        private Label lbl_Users;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbl_POS;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lbl_Logout;
        public Label lbl_Products;
        private Label lbl_Discounts;
    }
}