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
            btn_Edit = new Button();
            btn_Remove = new Button();
            tb_Search = new TextBox();
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
            dgv_Items.Location = new Point(4, 47);
            dgv_Items.Name = "dgv_Items";
            dgv_Items.ReadOnly = true;
            dgv_Items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Items.Size = new Size(1278, 659);
            dgv_Items.TabIndex = 0;
            dgv_Items.SelectionChanged += Dgv_Items_SelectionChanged;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.BackColor = Color.OliveDrab;
            btn_Add.Font = new Font("Comfortaa", 20.25F);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(1137, 712);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += Btn_Add_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.AutoSize = true;
            btn_Edit.BackColor = Color.SteelBlue;
            btn_Edit.Font = new Font("Comfortaa", 20.25F);
            btn_Edit.ForeColor = Color.White;
            btn_Edit.Location = new Point(997, 712);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(134, 60);
            btn_Edit.TabIndex = 9;
            btn_Edit.Text = "EDIT";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += Btn_Edit_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.AutoSize = true;
            btn_Remove.BackColor = Color.Tomato;
            btn_Remove.Font = new Font("Comfortaa", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Remove.ForeColor = Color.White;
            btn_Remove.Location = new Point(818, 712);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(173, 60);
            btn_Remove.TabIndex = 10;
            btn_Remove.Text = "- REMOVE";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += Btn_Remove_Click;
            // 
            // tb_Search
            // 
            tb_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Search.Location = new Point(12, 12);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(330, 29);
            tb_Search.TabIndex = 11;
            tb_Search.TextChanged += Tb_Search_TextChanged;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 784);
            Controls.Add(tb_Search);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Edit);
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
        private Button btn_Edit;
        private Button btn_Remove;
        private TextBox tb_Search;
    }
}