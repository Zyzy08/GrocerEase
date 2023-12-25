namespace GrocerEase
{
    partial class Products
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
            dgv_Items = new DataGridView();
            btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Items).BeginInit();
            SuspendLayout();
            // 
            // dgv_Items
            // 
            dgv_Items.AllowUserToAddRows = false;
            dgv_Items.AllowUserToDeleteRows = false;
            dgv_Items.AllowUserToResizeColumns = false;
            dgv_Items.AllowUserToResizeRows = false;
            dgv_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Items.Location = new Point(1, 1);
            dgv_Items.Name = "dgv_Items";
            dgv_Items.ReadOnly = true;
            dgv_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Items.Size = new Size(1281, 705);
            dgv_Items.TabIndex = 0;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(1137, 712);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += Btn_Add_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 784);
            Controls.Add(btn_Add);
            Controls.Add(dgv_Items);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Items).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Items;
        private Button btn_Add;
    }
}