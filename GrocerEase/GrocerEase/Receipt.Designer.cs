namespace GrocerEase
{
    partial class Receipt
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
            btn_Cancel = new Button();
            btn_Print = new Button();
            lv_List = new ListView();
            panel1 = new Panel();
            btn_Exit = new Button();
            lbl_Title = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_ReceiptNo = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_DateTime = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbl_Total = new Label();
            lbl_Discounts = new Label();
            lbl_VAT = new Label();
            lbl_Subtotal = new Label();
            label11 = new Label();
            lbl_Cashier = new Label();
            label13 = new Label();
            label14 = new Label();
            lbl_Change = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 781);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(190, 67);
            btn_Cancel.TabIndex = 16;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Print
            // 
            btn_Print.AutoSize = true;
            btn_Print.BackColor = Color.OliveDrab;
            btn_Print.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(405, 781);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(190, 67);
            btn_Print.TabIndex = 17;
            btn_Print.Text = "PRINT";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += Btn_Print_Click;
            // 
            // lv_List
            // 
            lv_List.BorderStyle = BorderStyle.None;
            lv_List.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_List.FullRowSelect = true;
            lv_List.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_List.Location = new Point(2, 203);
            lv_List.Name = "lv_List";
            lv_List.Size = new Size(602, 330);
            lv_List.TabIndex = 18;
            lv_List.UseCompatibleStateImageBehavior = false;
            lv_List.View = View.List;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 88, 110);
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(lbl_Title);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 61);
            panel1.TabIndex = 19;
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
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(12, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(583, 58);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "GrocerEase - Receipt";
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
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 64);
            label1.Name = "label1";
            label1.Size = new Size(602, 36);
            label1.TabIndex = 20;
            label1.Text = "GrocerEase";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 91);
            label2.Name = "label2";
            label2.Size = new Size(602, 36);
            label2.TabIndex = 21;
            label2.Text = "========================================================================";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_ReceiptNo
            // 
            lbl_ReceiptNo.BackColor = SystemColors.Window;
            lbl_ReceiptNo.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ReceiptNo.Location = new Point(2, 154);
            lbl_ReceiptNo.Name = "lbl_ReceiptNo";
            lbl_ReceiptNo.Size = new Size(602, 36);
            lbl_ReceiptNo.TabIndex = 22;
            lbl_ReceiptNo.Text = "Receipt #:";
            lbl_ReceiptNo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 181);
            label4.Name = "label4";
            label4.Size = new Size(602, 36);
            label4.TabIndex = 23;
            label4.Text = "========================================================================";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 659);
            label3.Name = "label3";
            label3.Size = new Size(602, 36);
            label3.TabIndex = 24;
            label3.Text = "--------------------------------------------------------------------------------------------------";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 723);
            label5.Name = "label5";
            label5.Size = new Size(602, 55);
            label5.TabIndex = 25;
            label5.Text = "Agson's Building, Mc Arthur Highway, Balibago, Angeles City, 2009, Pampanga, Philippines";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Window;
            label6.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(2, 695);
            label6.Name = "label6";
            label6.Size = new Size(602, 36);
            label6.TabIndex = 26;
            label6.Text = "--------------------------------------------------------------------------------------------------";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_DateTime
            // 
            lbl_DateTime.BackColor = SystemColors.Window;
            lbl_DateTime.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DateTime.Location = new Point(2, 682);
            lbl_DateTime.Name = "lbl_DateTime";
            lbl_DateTime.Size = new Size(602, 36);
            lbl_DateTime.TabIndex = 27;
            lbl_DateTime.Text = "Date: ";
            lbl_DateTime.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Window;
            label7.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(2, 614);
            label7.Name = "label7";
            label7.Size = new Size(200, 36);
            label7.TabIndex = 28;
            label7.Text = "Total:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Window;
            label8.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(2, 586);
            label8.Name = "label8";
            label8.Size = new Size(200, 36);
            label8.TabIndex = 29;
            label8.Text = "Discounts:";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Window;
            label9.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(2, 561);
            label9.Name = "label9";
            label9.Size = new Size(200, 36);
            label9.TabIndex = 30;
            label9.Text = "VAT (12%):";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Window;
            label10.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(2, 536);
            label10.Name = "label10";
            label10.Size = new Size(200, 36);
            label10.TabIndex = 31;
            label10.Text = "Subtotal:";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbl_Total
            // 
            lbl_Total.BackColor = SystemColors.Window;
            lbl_Total.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(199, 614);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.RightToLeft = RightToLeft.Yes;
            lbl_Total.Size = new Size(405, 36);
            lbl_Total.TabIndex = 32;
            lbl_Total.Text = "₱0.00";
            lbl_Total.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbl_Discounts
            // 
            lbl_Discounts.BackColor = SystemColors.Window;
            lbl_Discounts.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Discounts.Location = new Point(198, 586);
            lbl_Discounts.Name = "lbl_Discounts";
            lbl_Discounts.RightToLeft = RightToLeft.Yes;
            lbl_Discounts.Size = new Size(406, 36);
            lbl_Discounts.TabIndex = 33;
            lbl_Discounts.Text = "₱0.00-";
            lbl_Discounts.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbl_VAT
            // 
            lbl_VAT.BackColor = SystemColors.Window;
            lbl_VAT.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_VAT.Location = new Point(198, 561);
            lbl_VAT.Name = "lbl_VAT";
            lbl_VAT.RightToLeft = RightToLeft.Yes;
            lbl_VAT.Size = new Size(406, 36);
            lbl_VAT.TabIndex = 34;
            lbl_VAT.Text = "₱0.00";
            lbl_VAT.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.BackColor = SystemColors.Window;
            lbl_Subtotal.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtotal.Location = new Point(198, 536);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.RightToLeft = RightToLeft.Yes;
            lbl_Subtotal.Size = new Size(406, 36);
            lbl_Subtotal.TabIndex = 35;
            lbl_Subtotal.Text = "₱0.00";
            lbl_Subtotal.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Window;
            label11.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(2, 514);
            label11.Name = "label11";
            label11.Size = new Size(602, 36);
            label11.TabIndex = 36;
            label11.Text = "--------------------------------------------------------------------------------------------------";
            label11.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_Cashier
            // 
            lbl_Cashier.BackColor = SystemColors.Window;
            lbl_Cashier.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cashier.Location = new Point(2, 112);
            lbl_Cashier.Name = "lbl_Cashier";
            lbl_Cashier.Size = new Size(602, 36);
            lbl_Cashier.TabIndex = 37;
            lbl_Cashier.Text = "Cashier: Sayra Jackson #000001";
            // 
            // label13
            // 
            label13.BackColor = SystemColors.Window;
            label13.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(2, 132);
            label13.Name = "label13";
            label13.Size = new Size(602, 36);
            label13.TabIndex = 38;
            label13.Text = "========================================================================";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.Window;
            label14.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(2, 646);
            label14.Name = "label14";
            label14.Size = new Size(200, 36);
            label14.TabIndex = 39;
            label14.Text = "Change:";
            label14.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbl_Change
            // 
            lbl_Change.BackColor = SystemColors.Window;
            lbl_Change.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Change.Location = new Point(199, 646);
            lbl_Change.Name = "lbl_Change";
            lbl_Change.RightToLeft = RightToLeft.Yes;
            lbl_Change.Size = new Size(405, 36);
            lbl_Change.TabIndex = 40;
            lbl_Change.Text = "₱0.00";
            lbl_Change.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 161, 175);
            ClientSize = new Size(607, 860);
            Controls.Add(lv_List);
            Controls.Add(lbl_Change);
            Controls.Add(label14);
            Controls.Add(lbl_ReceiptNo);
            Controls.Add(label13);
            Controls.Add(lbl_Cashier);
            Controls.Add(label11);
            Controls.Add(lbl_Subtotal);
            Controls.Add(lbl_VAT);
            Controls.Add(lbl_Discounts);
            Controls.Add(lbl_Total);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(lbl_DateTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_Print);
            Controls.Add(btn_Cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Cancel;
        private Button btn_Print;

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        private ListView lv_List;
        private Panel panel1;
        private Button btn_Exit;
        private Label lbl_Title;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lbl_ReceiptNo;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label lbl_DateTime;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbl_Total;
        private Label lbl_Discounts;
        private Label lbl_VAT;
        private Label lbl_Subtotal;
        private Label label11;
        private Label lbl_Cashier;
        private Label label13;
        private Label label14;
        private Label lbl_Change;
    }
}