namespace Sayra
{
    partial class CategoryDetail
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
            pnl_Title = new Panel();
            lbl_Title = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            btn_Cancel = new Button();
            numericUpDown1 = new NumericUpDown();
            lbl_ID = new Label();
            tb_Name = new TextBox();
            label2 = new Label();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.OliveDrab;
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Controls.Add(button1);
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Margin = new Padding(3, 2, 3, 2);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(321, 51);
            pnl_Title.TabIndex = 35;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(11, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(295, 48);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "Add new category";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 14.25F);
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(37, 30);
            label1.TabIndex = 34;
            label1.Text = "ID:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(189, 165);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 46;
            button2.Text = "DONE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Btn_Done_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(11, 165);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(117, 44);
            btn_Cancel.TabIndex = 45;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(638, 923);
            numericUpDown1.Margin = new Padding(8, 10, 8, 10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(324, 23);
            numericUpDown1.TabIndex = 40;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Comfortaa", 14.25F);
            lbl_ID.Location = new Point(79, 62);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 30);
            lbl_ID.TabIndex = 39;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Name.Location = new Point(93, 105);
            tb_Name.Margin = new Padding(3, 2, 3, 2);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(213, 33);
            tb_Name.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 14.25F);
            label2.Location = new Point(11, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 36;
            label2.Text = "Name:";
            // 
            // CategoryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(318, 219);
            Controls.Add(pnl_Title);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btn_Cancel);
            Controls.Add(numericUpDown1);
            Controls.Add(lbl_ID);
            Controls.Add(tb_Name);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryDetail";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryDetail";
            Load += CategoryDetail_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_Title;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button btn_Cancel;
        private NumericUpDown numericUpDown1;
        public Label lbl_ID;
        private TextBox tb_Name;
        private Label label2;
    }
}