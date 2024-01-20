namespace Sayra
{
    partial class History
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
            dgv_Receipts = new DataGridView();
            dgv_ReceiptItems = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ReceiptItems).BeginInit();
            SuspendLayout();
            // 
            // dgv_Receipts
            // 
            dgv_Receipts.AllowUserToAddRows = false;
            dgv_Receipts.AllowUserToDeleteRows = false;
            dgv_Receipts.AllowUserToResizeColumns = false;
            dgv_Receipts.AllowUserToResizeRows = false;
            dgv_Receipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Receipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Receipts.Location = new Point(8, 51);
            dgv_Receipts.MultiSelect = false;
            dgv_Receipts.Name = "dgv_Receipts";
            dgv_Receipts.ReadOnly = true;
            dgv_Receipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Receipts.Size = new Size(649, 721);
            dgv_Receipts.TabIndex = 26;
            dgv_Receipts.SelectionChanged += Dgv_Receipts_SelectionChanged;
            // 
            // dgv_ReceiptItems
            // 
            dgv_ReceiptItems.AllowUserToAddRows = false;
            dgv_ReceiptItems.AllowUserToDeleteRows = false;
            dgv_ReceiptItems.AllowUserToResizeColumns = false;
            dgv_ReceiptItems.AllowUserToResizeRows = false;
            dgv_ReceiptItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ReceiptItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ReceiptItems.Location = new Point(660, 51);
            dgv_ReceiptItems.Name = "dgv_ReceiptItems";
            dgv_ReceiptItems.ReadOnly = true;
            dgv_ReceiptItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ReceiptItems.Size = new Size(649, 721);
            dgv_ReceiptItems.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 39);
            label1.TabIndex = 32;
            label1.Text = "Receipts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(660, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 39);
            label2.TabIndex = 33;
            label2.Text = "Items";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 784);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_ReceiptItems);
            Controls.Add(dgv_Receipts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ReceiptItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Receipts;
        private DataGridView dgv_ReceiptItems;
        private Label label1;
        private Label label2;
    }
}