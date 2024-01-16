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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            tb_Search = new TextBox();
            dgv_Receipts = new DataGridView();
            dgv_ReceiptItems = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ReceiptItems).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.Window;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(tb_Search);
            flowLayoutPanel1.Location = new Point(16, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(445, 34);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Search;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tb_Search
            // 
            tb_Search.BorderStyle = BorderStyle.None;
            tb_Search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Search.Location = new Point(37, 3);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(399, 26);
            tb_Search.TabIndex = 6;
            // 
            // dgv_Receipts
            // 
            dgv_Receipts.AllowUserToAddRows = false;
            dgv_Receipts.AllowUserToDeleteRows = false;
            dgv_Receipts.AllowUserToResizeColumns = false;
            dgv_Receipts.AllowUserToResizeRows = false;
            dgv_Receipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Receipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Receipts.Location = new Point(8, 50);
            dgv_Receipts.Name = "dgv_Receipts";
            dgv_Receipts.ReadOnly = true;
            dgv_Receipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Receipts.Size = new Size(649, 722);
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
            dgv_ReceiptItems.Location = new Point(660, 50);
            dgv_ReceiptItems.Name = "dgv_ReceiptItems";
            dgv_ReceiptItems.ReadOnly = true;
            dgv_ReceiptItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ReceiptItems.Size = new Size(649, 722);
            dgv_ReceiptItems.TabIndex = 31;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 784);
            Controls.Add(dgv_ReceiptItems);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgv_Receipts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += History_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ReceiptItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox tb_Search;
        private DataGridView dgv_Receipts;
        private DataGridView dgv_ReceiptItems;
    }
}