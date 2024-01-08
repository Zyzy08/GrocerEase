namespace GrocerEase
{
    partial class frmDiscount
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
            this.cmbDiscountType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPromotionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnApply = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.FormattingEnabled = true;
            this.cmbDiscountType.Items.AddRange(new object[] {
            "Senior Citizen",
            "PWD"});
            this.cmbDiscountType.Location = new System.Drawing.Point(155, 31);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(179, 21);
            this.cmbDiscountType.TabIndex = 0;
            this.cmbDiscountType.SelectedIndexChanged += new System.EventHandler(this.cmbDiscountType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promotion Type:";
            // 
            // cmbPromotionType
            // 
            this.cmbPromotionType.FormattingEnabled = true;
            this.cmbPromotionType.Items.AddRange(new object[] {
            "BOGO",
            "10% off",
            "Bundle Deals (20% off)",
            "Flash Sale (30%off)",
            "Season (50% off)"});
            this.cmbPromotionType.Location = new System.Drawing.Point(155, 75);
            this.cmbPromotionType.Name = "cmbPromotionType";
            this.cmbPromotionType.Size = new System.Drawing.Size(179, 21);
            this.cmbPromotionType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mode of Payment:";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit Card",
            "E-Wallet"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(155, 120);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(179, 21);
            this.cmbPaymentMode.TabIndex = 4;
            this.cmbPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMode_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 35;
            this.btnBack.Location = new System.Drawing.Point(404, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F);
            this.btnApply.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnApply.IconColor = System.Drawing.Color.Black;
            this.btnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApply.Location = new System.Drawing.Point(33, 255);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(103, 32);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(192)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(454, 299);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPaymentMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPromotionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDiscountType);
            this.Name = "frmDiscount";
            this.Text = "frmDiscount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiscountType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPromotionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnApply;
    }
}