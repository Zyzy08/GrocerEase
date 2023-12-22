namespace GrocerEase
{
    partial class NewProduct
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_Name = new TextBox();
            txt_NetWT = new TextBox();
            pb_Image = new PictureBox();
            cb_Category = new ComboBox();
            StockManagement_btn_Done = new Button();
            StockManagement_btn_Cancel = new Button();
            nud_Price = new NumericUpDown();
            label8 = new Label();
            lbl_ID = new Label();
            nud_InStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pb_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_InStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 84);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 141);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "NetWT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Image";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 227);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 255);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "In-Stock";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(98, 81);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(100, 23);
            txt_Name.TabIndex = 7;
            // 
            // txt_NetWT
            // 
            txt_NetWT.Location = new Point(98, 110);
            txt_NetWT.Name = "txt_NetWT";
            txt_NetWT.Size = new Size(100, 23);
            txt_NetWT.TabIndex = 9;
            // 
            // pb_Image
            // 
            pb_Image.Image = Properties.Resources.Upload;
            pb_Image.Location = new Point(99, 168);
            pb_Image.Name = "pb_Image";
            pb_Image.Size = new Size(100, 50);
            pb_Image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Image.TabIndex = 10;
            pb_Image.TabStop = false;
            pb_Image.Click += Pb_Image_Click;
            // 
            // cb_Category
            // 
            cb_Category.FormattingEnabled = true;
            cb_Category.Location = new Point(98, 224);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(121, 23);
            cb_Category.TabIndex = 12;
            // 
            // StockManagement_btn_Done
            // 
            StockManagement_btn_Done.Location = new Point(12, 282);
            StockManagement_btn_Done.Name = "StockManagement_btn_Done";
            StockManagement_btn_Done.Size = new Size(75, 23);
            StockManagement_btn_Done.TabIndex = 14;
            StockManagement_btn_Done.Text = "Done";
            StockManagement_btn_Done.UseVisualStyleBackColor = true;
            StockManagement_btn_Done.Click += StockManagement_btn_Done_Click;
            // 
            // StockManagement_btn_Cancel
            // 
            StockManagement_btn_Cancel.Location = new Point(144, 282);
            StockManagement_btn_Cancel.Name = "StockManagement_btn_Cancel";
            StockManagement_btn_Cancel.Size = new Size(75, 23);
            StockManagement_btn_Cancel.TabIndex = 15;
            StockManagement_btn_Cancel.Text = "Cancel";
            StockManagement_btn_Cancel.UseVisualStyleBackColor = true;
            StockManagement_btn_Cancel.Click += StockManagement_btn_Cancel_Click;
            // 
            // nud_Price
            // 
            nud_Price.DecimalPlaces = 2;
            nud_Price.Location = new Point(99, 139);
            nud_Price.Name = "nud_Price";
            nud_Price.Size = new Size(120, 23);
            nud_Price.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 48);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 17;
            label8.Text = "ID";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(98, 48);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 15);
            lbl_ID.TabIndex = 18;
            // 
            // nud_InStock
            // 
            nud_InStock.Location = new Point(99, 253);
            nud_InStock.Name = "nud_InStock";
            nud_InStock.Size = new Size(120, 23);
            nud_InStock.TabIndex = 19;
            // 
            // NewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nud_InStock);
            Controls.Add(lbl_ID);
            Controls.Add(label8);
            Controls.Add(nud_Price);
            Controls.Add(StockManagement_btn_Cancel);
            Controls.Add(StockManagement_btn_Done);
            Controls.Add(cb_Category);
            Controls.Add(pb_Image);
            Controls.Add(txt_NetWT);
            Controls.Add(txt_Name);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Product";
            Load += NewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Price).EndInit();
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
        private TextBox txt_Name;
        private TextBox txt_NetWT;
        private PictureBox pb_Image;
        private ComboBox cb_Category;
        private Button StockManagement_btn_Done;
        private Button StockManagement_btn_Cancel;
        private NumericUpDown nud_Price;
        private Label label8;
        private Label lbl_ID;
        private NumericUpDown nud_InStock;
    }
}