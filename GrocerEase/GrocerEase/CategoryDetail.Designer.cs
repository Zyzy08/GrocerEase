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
            lbl_ID = new Label();
            label8 = new Label();
            btn_Cancel = new Button();
            btn_Done = new Button();
            tb_Name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(110, 48);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(0, 15);
            lbl_ID.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 48);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 33;
            label8.Text = "ID";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(155, 122);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 31;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Done
            // 
            btn_Done.Location = new Point(23, 122);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new Size(75, 23);
            btn_Done.TabIndex = 30;
            btn_Done.Text = "Done";
            btn_Done.UseVisualStyleBackColor = true;
            btn_Done.Click += Btn_Done_Click;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(110, 81);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(100, 23);
            tb_Name.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 84);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 20;
            label1.Text = "Name";
            // 
            // CategoryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 189);
            Controls.Add(lbl_ID);
            Controls.Add(label8);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Done);
            Controls.Add(tb_Name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryDetail";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryDetail";
            Load += CategoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_ID;
        private Label label8;
        private Button btn_Cancel;
        private Button btn_Done;
        private TextBox tb_Name;
        private Label label1;
    }
}