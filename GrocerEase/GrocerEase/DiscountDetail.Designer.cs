namespace Sayra
{
    partial class DiscountDetail
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
            pnl_Title = new Panel();
            btn_Exit = new Button();
            lbl_Title = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            tb_Type = new TextBox();
            lbl_ID = new Label();
            numericUpDown1 = new NumericUpDown();
            nud_Rate = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cb_Status = new ComboBox();
            btn_Cancel = new Button();
            button2 = new Button();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Rate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 14.25F);
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(37, 30);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.OliveDrab;
            pnl_Title.Controls.Add(btn_Exit);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Controls.Add(button1);
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Margin = new Padding(3, 2, 3, 2);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(321, 51);
            pnl_Title.TabIndex = 20;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(694, 10);
            btn_Exit.Margin = new Padding(3, 2, 3, 2);
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
            lbl_Title.Location = new Point(11, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(295, 48);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "Add new discount";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1281, 10);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 14.25F);
            label2.Location = new Point(11, 104);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 21;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 14.25F);
            label3.Location = new Point(11, 157);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 22;
            label3.Text = "Rate:";
            // 
            // tb_Type
            // 
            tb_Type.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Type.Location = new Point(79, 105);
            tb_Type.Margin = new Padding(3, 2, 3, 2);
            tb_Type.Name = "tb_Type";
            tb_Type.Size = new Size(227, 33);
            tb_Type.TabIndex = 23;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Comfortaa", 14.25F);
            lbl_ID.Location = new Point(79, 62);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 30);
            lbl_ID.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(638, 923);
            numericUpDown1.Margin = new Padding(8, 10, 8, 10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(324, 33);
            numericUpDown1.TabIndex = 25;
            // 
            // nud_Rate
            // 
            nud_Rate.Location = new Point(79, 159);
            nud_Rate.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nud_Rate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Rate.Name = "nud_Rate";
            nud_Rate.Size = new Size(111, 33);
            nud_Rate.TabIndex = 26;
            nud_Rate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa", 14.25F);
            label5.Location = new Point(196, 157);
            label5.Name = "label5";
            label5.Size = new Size(29, 30);
            label5.TabIndex = 27;
            label5.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 14.25F);
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 30;
            label4.Text = "Status:";
            // 
            // cb_Status
            // 
            cb_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Status.FlatStyle = FlatStyle.Flat;
            cb_Status.Font = new Font("Comfortaa", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Status.FormattingEnabled = true;
            cb_Status.Items.AddRange(new object[] { "Enable", "Disable" });
            cb_Status.Location = new Point(100, 211);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(121, 38);
            cb_Status.TabIndex = 31;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 270);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(117, 44);
            btn_Cancel.TabIndex = 32;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(189, 270);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 33;
            button2.Text = "DONE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Btn_Done_Click;
            // 
            // DiscountDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(318, 324);
            Controls.Add(button2);
            Controls.Add(btn_Cancel);
            Controls.Add(cb_Status);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(nud_Rate);
            Controls.Add(numericUpDown1);
            Controls.Add(lbl_ID);
            Controls.Add(tb_Type);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnl_Title);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "DiscountDetail";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountDetail";
            Load += DiscountDetail_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Rate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnl_Title;
        private Button btn_Exit;
        private Label lbl_Title;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox tb_Type;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nud_Rate;
        private Label label5;
        public Label lbl_ID;
        private Label label4;
        private ComboBox cb_Status;
        private Button btn_Cancel;
        private Button button2;
    }
}