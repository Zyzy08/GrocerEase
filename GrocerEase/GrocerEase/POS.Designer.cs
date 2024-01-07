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
            tb_Search = new TextBox();
            nud_Quantity = new NumericUpDown();
            tc_Categories = new TabControl();
            btn_Add = new Button();
            panel1 = new Panel();
            lbl_Discounts = new Label();
            label5 = new Label();
            flp_Discounts = new FlowLayoutPanel();
            lbl_VAT = new Label();
            lbl_Subtotal = new Label();
            label3 = new Label();
            label2 = new Label();
            lv_Bag = new ListView();
            label1 = new Label();
            lbl_Total = new Label();
            btn_Pay = new Button();
            btn_Remove = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(8, 744);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(132, 34);
            lbl_Price.TabIndex = 10;
            lbl_Price.Text = "Price: ₱0.00";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Name.Location = new Point(8, 714);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(50, 26);
            lbl_Name.TabIndex = 9;
            lbl_Name.Text = "Item:";
            // 
            // tb_Search
            // 
            tb_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Search.Location = new Point(8, 10);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(330, 29);
            tb_Search.TabIndex = 6;
            tb_Search.TextChanged += Tb_Search_TextChanged;
            // 
            // nud_Quantity
            // 
            nud_Quantity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Quantity.Location = new Point(433, 729);
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
            tc_Categories.Size = new Size(647, 666);
            tc_Categories.TabIndex = 5;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(514, 718);
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
            panel1.Controls.Add(lbl_Discounts);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(flp_Discounts);
            panel1.Controls.Add(lbl_VAT);
            panel1.Controls.Add(lbl_Subtotal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lv_Bag);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(648, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 699);
            panel1.TabIndex = 11;
            // 
            // lbl_Discounts
            // 
            lbl_Discounts.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Discounts.Location = new Point(305, 665);
            lbl_Discounts.Name = "lbl_Discounts";
            lbl_Discounts.RightToLeft = RightToLeft.Yes;
            lbl_Discounts.Size = new Size(349, 34);
            lbl_Discounts.TabIndex = 21;
            lbl_Discounts.Text = "₱0.00-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 665);
            label5.Name = "label5";
            label5.Size = new Size(122, 34);
            label5.TabIndex = 20;
            label5.Text = "Discounts";
            // 
            // flp_Discounts
            // 
            flp_Discounts.BackColor = SystemColors.Window;
            flp_Discounts.BorderStyle = BorderStyle.FixedSingle;
            flp_Discounts.FlowDirection = FlowDirection.TopDown;
            flp_Discounts.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flp_Discounts.ForeColor = SystemColors.GrayText;
            flp_Discounts.Location = new Point(3, 37);
            flp_Discounts.Name = "flp_Discounts";
            flp_Discounts.Size = new Size(202, 557);
            flp_Discounts.TabIndex = 19;
            // 
            // lbl_VAT
            // 
            lbl_VAT.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_VAT.Location = new Point(305, 631);
            lbl_VAT.Name = "lbl_VAT";
            lbl_VAT.RightToLeft = RightToLeft.Yes;
            lbl_VAT.Size = new Size(349, 34);
            lbl_VAT.TabIndex = 18;
            lbl_VAT.Text = "₱0.00";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Subtotal.Location = new Point(305, 597);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.RightToLeft = RightToLeft.Yes;
            lbl_Subtotal.Size = new Size(349, 34);
            lbl_Subtotal.TabIndex = 17;
            lbl_Subtotal.Text = "₱0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 597);
            label3.Name = "label3";
            label3.Size = new Size(108, 34);
            label3.TabIndex = 16;
            label3.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 631);
            label2.Name = "label2";
            label2.Size = new Size(110, 34);
            label2.TabIndex = 15;
            label2.Text = "VAT (12%)";
            // 
            // lv_Bag
            // 
            lv_Bag.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_Bag.FullRowSelect = true;
            lv_Bag.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_Bag.Location = new Point(204, 37);
            lv_Bag.Name = "lv_Bag";
            lv_Bag.Size = new Size(450, 557);
            lv_Bag.TabIndex = 14;
            lv_Bag.UseCompatibleStateImageBehavior = false;
            lv_Bag.View = View.List;
            lv_Bag.SelectedIndexChanged += Lv_Bag_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(657, 34);
            label1.TabIndex = 13;
            label1.Text = "ECO Bag";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(775, 740);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(0, 39);
            lbl_Total.TabIndex = 19;
            // 
            // btn_Pay
            // 
            btn_Pay.AutoSize = true;
            btn_Pay.BackColor = Color.OliveDrab;
            btn_Pay.Enabled = false;
            btn_Pay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pay.ForeColor = Color.White;
            btn_Pay.Location = new Point(1168, 719);
            btn_Pay.Name = "btn_Pay";
            btn_Pay.Size = new Size(134, 60);
            btn_Pay.TabIndex = 21;
            btn_Pay.Text = "PAY";
            btn_Pay.UseVisualStyleBackColor = false;
            btn_Pay.Click += Btn_Pay_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.AutoSize = true;
            btn_Remove.BackColor = Color.Tomato;
            btn_Remove.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Remove.ForeColor = Color.White;
            btn_Remove.Location = new Point(1153, 719);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(149, 60);
            btn_Remove.TabIndex = 22;
            btn_Remove.Text = "- REMOVE";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Visible = false;
            btn_Remove.Click += Btn_Remove_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(651, 740);
            label4.Name = "label4";
            label4.Size = new Size(127, 39);
            label4.TabIndex = 23;
            label4.Text = "TOTAL: ₱";
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 784);
            Controls.Add(label4);
            Controls.Add(btn_Pay);
            Controls.Add(btn_Remove);
            Controls.Add(lbl_Total);
            Controls.Add(panel1);
            Controls.Add(lbl_Price);
            Controls.Add(lbl_Name);
            Controls.Add(tb_Search);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Price;
        private Label lbl_Name;
        private TextBox tb_Search;
        private NumericUpDown nud_Quantity;
        private TabControl tc_Categories;
        private Button btn_Add;
        private Panel panel1;
        private Label label1;
        private ListView lv_Bag;
        private Label label3;
        private Label label2;
        private Label lbl_VAT;
        private Label lbl_Subtotal;
        private Label lbl_Total;
        private Button btn_Pay;
        private Button btn_Remove;
        private FlowLayoutPanel flp_Discounts;
        private Label label5;
        private Label lbl_Discounts;
        private Label label4;
    }
}