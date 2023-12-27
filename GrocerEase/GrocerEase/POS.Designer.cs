namespace GrocerEase
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
            lbl_Price = new Label();
            lbl_Name = new Label();
            textBox1 = new TextBox();
            nud_Quantity = new NumericUpDown();
            tc_Categories = new TabControl();
            btn_Add = new Button();
            panel1 = new Panel();
            tlp_Bag = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            panel1.SuspendLayout();
            tlp_Bag.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(8, 747);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(119, 30);
            lbl_Price.TabIndex = 10;
            lbl_Price.Text = "Price: ₱0.00";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Name.Location = new Point(10, 717);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(80, 30);
            lbl_Name.TabIndex = 9;
            lbl_Name.Text = "Name: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(8, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 29);
            textBox1.TabIndex = 6;
            // 
            // nud_Quantity
            // 
            nud_Quantity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Quantity.Location = new Point(443, 728);
            nud_Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new Size(75, 43);
            nud_Quantity.TabIndex = 8;
            nud_Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.ValueChanged += Nud_Quantity_ValueChanged;
            // 
            // tc_Categories
            // 
            tc_Categories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_Categories.Location = new Point(1, 45);
            tc_Categories.Name = "tc_Categories";
            tc_Categories.SelectedIndex = 0;
            tc_Categories.Size = new Size(657, 666);
            tc_Categories.TabIndex = 5;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(524, 717);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += Btn_Add_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tlp_Bag);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(664, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 699);
            panel1.TabIndex = 11;
            // 
            // tlp_Bag
            // 
            tlp_Bag.AutoSize = true;
            tlp_Bag.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_Bag.ColumnCount = 3;
            tlp_Bag.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp_Bag.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Bag.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Bag.Controls.Add(label4, 2, 0);
            tlp_Bag.Controls.Add(label3, 1, 0);
            tlp_Bag.Controls.Add(label2, 0, 0);
            tlp_Bag.Font = new Font("Comfortaa Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlp_Bag.Location = new Point(3, 37);
            tlp_Bag.Name = "tlp_Bag";
            tlp_Bag.RowCount = 3;
            tlp_Bag.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Bag.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Bag.RowStyles.Add(new RowStyle());
            tlp_Bag.Size = new Size(460, 52);
            tlp_Bag.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 26);
            label4.TabIndex = 2;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 1;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 26);
            label2.TabIndex = 0;
            label2.Text = "Item";
            // 
            // label1
            // 
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(607, 34);
            label1.TabIndex = 13;
            label1.Text = "ECO Bag";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 784);
            Controls.Add(panel1);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_Name);
            Controls.Add(textBox1);
            Controls.Add(nud_Quantity);
            Controls.Add(tc_Categories);
            Controls.Add(btn_Add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POS";
            Text = "POS";
            Load += POS_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tlp_Bag.ResumeLayout(false);
            tlp_Bag.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Price;
        private Label lbl_Name;
        private TextBox textBox1;
        private NumericUpDown nud_Quantity;
        private TabControl tc_Categories;
        private Button btn_Add;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tlp_Bag;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}