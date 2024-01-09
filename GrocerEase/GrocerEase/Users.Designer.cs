namespace Sayra
{
    partial class Users
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
            btn_Remove = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            dgv_Users = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.Window;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(tb_Search);
            flowLayoutPanel1.Location = new Point(12, 7);
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
            tb_Search.TextChanged += Tb_Search_TextChanged;
            // 
            // btn_Remove
            // 
            btn_Remove.AutoSize = true;
            btn_Remove.BackColor = Color.Tomato;
            btn_Remove.Font = new Font("Comfortaa", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Remove.ForeColor = Color.White;
            btn_Remove.Location = new Point(852, 712);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(173, 60);
            btn_Remove.TabIndex = 29;
            btn_Remove.Text = "- REMOVE";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += Btn_Remove_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.AutoSize = true;
            btn_Edit.BackColor = Color.SteelBlue;
            btn_Edit.Font = new Font("Comfortaa", 20.25F);
            btn_Edit.ForeColor = Color.White;
            btn_Edit.Location = new Point(1031, 712);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(134, 60);
            btn_Edit.TabIndex = 28;
            btn_Edit.Text = "EDIT";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += Btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = true;
            btn_Add.BackColor = Color.OliveDrab;
            btn_Add.Font = new Font("Comfortaa", 20.25F);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(1171, 712);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(134, 60);
            btn_Add.TabIndex = 27;
            btn_Add.Text = "+ ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += Btn_Add_Click;
            // 
            // dgv_Users
            // 
            dgv_Users.AllowUserToAddRows = false;
            dgv_Users.AllowUserToDeleteRows = false;
            dgv_Users.AllowUserToResizeColumns = false;
            dgv_Users.AllowUserToResizeRows = false;
            dgv_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(4, 47);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.ReadOnly = true;
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.Size = new Size(1301, 659);
            dgv_Users.TabIndex = 26;
            dgv_Users.SelectionChanged += Dgv_Users_SelectionChanged;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 784);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(dgv_Users);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox tb_Search;
        private Button btn_Remove;
        private Button btn_Edit;
        private Button btn_Add;
        private DataGridView dgv_Users;
    }
}