namespace GrocerEase
{
    partial class ProductDetail
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
            pnl_Title = new Panel();
            lbl_Title = new Label();
            label4 = new Label();
            lbl_ID = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tb_Name = new TextBox();
            tb_NetWT = new TextBox();
            nud_Price = new NumericUpDown();
            pb_Image = new PictureBox();
            cb_Category = new ComboBox();
            nud_InStock = new NumericUpDown();
            btn_Cancel = new Button();
            btn_Done = new Button();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_InStock).BeginInit();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.OliveDrab;
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Location = new Point(-1, 0);
            pnl_Title.Margin = new Padding(3, 2, 3, 2);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(321, 51);
            pnl_Title.TabIndex = 48;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(11, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(295, 48);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "Add new product";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 14.25F);
            label4.Location = new Point(10, 62);
            label4.Name = "label4";
            label4.Size = new Size(37, 30);
            label4.TabIndex = 47;
            label4.Text = "ID:";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Comfortaa", 14.25F);
            lbl_ID.Location = new Point(78, 62);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 30);
            lbl_ID.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comfortaa", 14.25F);
            label10.Location = new Point(10, 104);
            label10.Name = "label10";
            label10.Size = new Size(76, 30);
            label10.TabIndex = 49;
            label10.Text = "Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comfortaa", 14.25F);
            label11.Location = new Point(10, 157);
            label11.Name = "label11";
            label11.Size = new Size(83, 30);
            label11.TabIndex = 54;
            label11.Text = "NetWT:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comfortaa", 14.25F);
            label12.Location = new Point(10, 209);
            label12.Name = "label12";
            label12.Size = new Size(66, 30);
            label12.TabIndex = 57;
            label12.Text = "Price:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comfortaa", 14.25F);
            label13.Location = new Point(10, 271);
            label13.Name = "label13";
            label13.Size = new Size(78, 30);
            label13.TabIndex = 58;
            label13.Text = "Image:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comfortaa", 14.25F);
            label14.Location = new Point(10, 327);
            label14.Name = "label14";
            label14.Size = new Size(109, 30);
            label14.TabIndex = 60;
            label14.Text = "Category:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comfortaa", 14.25F);
            label15.Location = new Point(10, 381);
            label15.Name = "label15";
            label15.Size = new Size(98, 30);
            label15.TabIndex = 62;
            label15.Text = "In-Stock:";
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Name.Location = new Point(92, 105);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(213, 29);
            tb_Name.TabIndex = 63;
            // 
            // tb_NetWT
            // 
            tb_NetWT.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_NetWT.Location = new Point(99, 158);
            tb_NetWT.Name = "tb_NetWT";
            tb_NetWT.Size = new Size(128, 29);
            tb_NetWT.TabIndex = 64;
            // 
            // nud_Price
            // 
            nud_Price.DecimalPlaces = 2;
            nud_Price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Price.Location = new Point(82, 211);
            nud_Price.Name = "nud_Price";
            nud_Price.Size = new Size(175, 33);
            nud_Price.TabIndex = 65;
            // 
            // pb_Image
            // 
            pb_Image.Image = Sayra.Properties.Resources.Upload;
            pb_Image.Location = new Point(94, 251);
            pb_Image.Name = "pb_Image";
            pb_Image.Size = new Size(55, 50);
            pb_Image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Image.TabIndex = 66;
            pb_Image.TabStop = false;
            pb_Image.Click += Pb_Image_Click;
            // 
            // cb_Category
            // 
            cb_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Category.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Category.FormattingEnabled = true;
            cb_Category.Location = new Point(125, 328);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(180, 33);
            cb_Category.TabIndex = 67;
            // 
            // nud_InStock
            // 
            nud_InStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_InStock.Location = new Point(114, 383);
            nud_InStock.Name = "nud_InStock";
            nud_InStock.Size = new Size(113, 33);
            nud_InStock.TabIndex = 68;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(10, 428);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(117, 44);
            btn_Cancel.TabIndex = 69;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Done
            // 
            btn_Done.AutoSize = true;
            btn_Done.BackColor = Color.OliveDrab;
            btn_Done.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Done.ForeColor = Color.White;
            btn_Done.Location = new Point(189, 428);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new Size(117, 44);
            btn_Done.TabIndex = 70;
            btn_Done.Text = "DONE";
            btn_Done.UseVisualStyleBackColor = false;
            btn_Done.Click += Btn_Done_Click;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(318, 484);
            Controls.Add(btn_Done);
            Controls.Add(btn_Cancel);
            Controls.Add(nud_InStock);
            Controls.Add(cb_Category);
            Controls.Add(pb_Image);
            Controls.Add(nud_Price);
            Controls.Add(tb_NetWT);
            Controls.Add(tb_Name);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pnl_Title);
            Controls.Add(label4);
            Controls.Add(lbl_ID);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetail";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += ProductDetail_Load;
            pnl_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_InStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pb_Image;
        private Button btn_Done;
        private Button btn_Cancel;
        private Label label8;
        public Label lbl_ID;
        private Panel pnl_Title;
        private Label lbl_Title;
        private Label label4;
        public Label label9;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private NumericUpDown nud_Price;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tb_Name;
        private TextBox tb_NetWT;
        private ComboBox cb_Category;
        private NumericUpDown nud_InStock;
    }
}