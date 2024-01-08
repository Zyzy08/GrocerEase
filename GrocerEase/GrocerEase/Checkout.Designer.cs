namespace Sayra
{
    partial class Checkout
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
            lbl_Total = new Label();
            label2 = new Label();
            btn_Checkout = new Button();
            btn_Cancel = new Button();
            label3 = new Label();
            nud_Cash = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            lbl_Title = new Label();
            button1 = new Button();
            lbl_Change = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Cash).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(157, 63);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(0, 57);
            lbl_Total.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(159, 57);
            label2.TabIndex = 1;
            label2.Text = "Cash: ₱";
            // 
            // btn_Checkout
            // 
            btn_Checkout.AutoSize = true;
            btn_Checkout.BackColor = Color.OliveDrab;
            btn_Checkout.Enabled = false;
            btn_Checkout.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Checkout.ForeColor = Color.White;
            btn_Checkout.Location = new Point(314, 270);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(197, 67);
            btn_Checkout.TabIndex = 3;
            btn_Checkout.Text = "CHECKOUT";
            btn_Checkout.UseVisualStyleBackColor = false;
            btn_Checkout.Click += Btn_Receipt_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 270);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(190, 67);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(211, 57);
            label3.TabIndex = 5;
            label3.Text = "Change: ₱";
            // 
            // nud_Cash
            // 
            nud_Cash.DecimalPlaces = 2;
            nud_Cash.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nud_Cash.Location = new Point(157, 135);
            nud_Cash.Maximum = new decimal(new int[] { 99999999, 0, 0, 131072 });
            nud_Cash.Name = "nud_Cash";
            nud_Cash.Size = new Size(347, 54);
            nud_Cash.TabIndex = 6;
            nud_Cash.ValueChanged += Nud_Cash_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(157, 57);
            label1.TabIndex = 7;
            label1.Text = "Total: ₱";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(lbl_Title);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 61);
            panel1.TabIndex = 8;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(12, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(492, 58);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "GrocerEase - Checkout";
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
            // lbl_Change
            // 
            lbl_Change.AutoSize = true;
            lbl_Change.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Change.Location = new Point(211, 202);
            lbl_Change.Name = "lbl_Change";
            lbl_Change.Size = new Size(0, 57);
            lbl_Change.TabIndex = 9;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 200, 148);
            ClientSize = new Size(516, 349);
            Controls.Add(lbl_Change);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(nud_Cash);
            Controls.Add(label3);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Checkout);
            Controls.Add(label2);
            Controls.Add(lbl_Total);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)nud_Cash).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Total;
        private Label label2;
        private Button btn_Checkout;
        private Button btn_Cancel;
        private Label label3;
        private NumericUpDown nud_Cash;
        private Label label1;
        private Panel panel1;
        private Label lbl_Title;
        private Button button1;
        private Label lbl_Change;
    }
}