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
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
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
            nud_Quantity.Location = new Point(587, 734);
            nud_Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new Size(136, 43);
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
            tc_Categories.Size = new Size(862, 675);
            tc_Categories.TabIndex = 5;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(729, 723);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 784);
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
    }
}