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
            tb_Cash = new TextBox();
            btn_Receipt = new Button();
            btn_Cancel = new Button();
            lbl_Change = new Label();
            SuspendLayout();
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(12, 9);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(157, 57);
            lbl_Total.TabIndex = 0;
            lbl_Total.Text = "Total: ₱";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(159, 57);
            label2.TabIndex = 1;
            label2.Text = "Cash: ₱";
            // 
            // tb_Cash
            // 
            tb_Cash.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Cash.Location = new Point(177, 100);
            tb_Cash.MaxLength = 16;
            tb_Cash.Name = "tb_Cash";
            tb_Cash.Size = new Size(326, 57);
            tb_Cash.TabIndex = 2;
            tb_Cash.Text = "0";
            tb_Cash.TextChanged += Tb_Cash_TextChanged;
            tb_Cash.KeyPress += Tb_Cash_KeyPress;
            // 
            // btn_Receipt
            // 
            btn_Receipt.AutoSize = true;
            btn_Receipt.BackColor = Color.OliveDrab;
            btn_Receipt.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Receipt.ForeColor = Color.White;
            btn_Receipt.Location = new Point(52, 272);
            btn_Receipt.Name = "btn_Receipt";
            btn_Receipt.Size = new Size(190, 67);
            btn_Receipt.TabIndex = 3;
            btn_Receipt.Text = "RECEIPT";
            btn_Receipt.UseVisualStyleBackColor = false;
            btn_Receipt.Click += Btn_Receipt_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(281, 272);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(190, 67);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // lbl_Change
            // 
            lbl_Change.AutoSize = true;
            lbl_Change.Font = new Font("Comfortaa", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Change.Location = new Point(12, 181);
            lbl_Change.Name = "lbl_Change";
            lbl_Change.Size = new Size(277, 57);
            lbl_Change.TabIndex = 5;
            lbl_Change.Text = "Change: ₱0.00";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(516, 351);
            Controls.Add(lbl_Change);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Receipt);
            Controls.Add(tb_Cash);
            Controls.Add(label2);
            Controls.Add(lbl_Total);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Total;
        private Label label2;
        private TextBox tb_Cash;
        private Button btn_Receipt;
        private Button btn_Cancel;
        private Label lbl_Change;
    }
}