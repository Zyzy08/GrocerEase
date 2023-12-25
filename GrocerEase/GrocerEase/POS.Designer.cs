﻿namespace GrocerEase
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            tc_Categories = new TabControl();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Settings = new PictureBox();
            panel1 = new Panel();
            btn_Exit = new Button();
            btn_Add = new Button();
            panel2 = new Panel();
            lbl_Price = new Label();
            lbl_Name = new Label();
            nud_Quantity = new NumericUpDown();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label6 = new Label();
            lbl_Products = new Label();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tc_Categories
            // 
            tc_Categories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_Categories.Location = new Point(3, 3);
            tc_Categories.Name = "tc_Categories";
            tc_Categories.SelectedIndex = 0;
            tc_Categories.Size = new Size(862, 666);
            tc_Categories.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(155, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 29);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_Settings
            // 
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.Location = new Point(940, 64);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(45, 43);
            btn_Settings.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Settings.TabIndex = 3;
            btn_Settings.TabStop = false;
            btn_Settings.Click += Btn_Settings_Click;
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
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(1397, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(31, 33);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(689, 671);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_Price);
            panel2.Controls.Add(lbl_Name);
            panel2.Controls.Add(nud_Quantity);
            panel2.Controls.Add(tc_Categories);
            panel2.Controls.Add(btn_Add);
            panel2.Location = new Point(145, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 735);
            panel2.TabIndex = 5;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(3, 702);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(119, 30);
            lbl_Price.TabIndex = 4;
            lbl_Price.Text = "Price: ₱0.00";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Name.Location = new Point(3, 672);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(80, 30);
            lbl_Name.TabIndex = 3;
            lbl_Name.Text = "Name: ";
            // 
            // nud_Quantity
            // 
            nud_Quantity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Quantity.Location = new Point(547, 681);
            nud_Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new Size(136, 43);
            nud_Quantity.TabIndex = 2;
            nud_Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.ValueChanged += Nud_Quantity_ValueChanged;
            // 
            // panel3
            // 
            panel3.Location = new Point(991, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 784);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 784);
            panel4.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(lbl_Products);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Controls.Add(label12);
            flowLayoutPanel1.Controls.Add(label13);
            flowLayoutPanel1.Controls.Add(label14);
            flowLayoutPanel1.Controls.Add(label15);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(-3, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(154, 659);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 38);
            label2.TabIndex = 0;
            label2.Text = " Dashboard";
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
            lbl_Products.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Products.ForeColor = Color.SandyBrown;
            lbl_Products.Location = new Point(3, 76);
            lbl_Products.Name = "lbl_Products";
            lbl_Products.Size = new Size(154, 38);
            lbl_Products.TabIndex = 1;
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
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SandyBrown;
            label4.Location = new Point(3, 152);
            label4.Name = "label4";
            label4.Size = new Size(154, 38);
            label4.TabIndex = 2;
            label4.Text = "Categories";
            label4.TextAlign = ContentAlignment.TopCenter;
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
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SandyBrown;
            label5.Location = new Point(3, 228);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 3;
            label5.Text = "Users";
            label5.TextAlign = ContentAlignment.TopCenter;
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
            // label10
            // 
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 304);
            label10.Name = "label10";
            label10.Size = new Size(154, 38);
            label10.TabIndex = 5;
            // 
            // label11
            // 
            label11.BackColor = Color.SandyBrown;
            label11.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 342);
            label11.Name = "label11";
            label11.Size = new Size(154, 38);
            label11.TabIndex = 6;
            label11.Text = "POS";
            label11.TextAlign = ContentAlignment.TopCenter;
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
            // label13
            // 
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 418);
            label13.Name = "label13";
            label13.Size = new Size(154, 38);
            label13.TabIndex = 8;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 456);
            label14.Name = "label14";
            label14.Size = new Size(154, 38);
            label14.TabIndex = 9;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.Control;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.SandyBrown;
            label15.Location = new Point(3, 494);
            label15.Name = "label15";
            label15.Size = new Size(154, 38);
            label15.TabIndex = 10;
            label15.Text = "Logout";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 860);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Settings);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += POS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).EndInit();
            panel4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tc_Categories;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox btn_Settings;
        private Panel panel1;
        private Button btn_Add;
        private Panel panel2;
        private NumericUpDown nud_Quantity;
        private Label lbl_Price;
        private Label lbl_Name;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Button btn_Exit;
        private Label label4;
        private Label lbl_Products;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}