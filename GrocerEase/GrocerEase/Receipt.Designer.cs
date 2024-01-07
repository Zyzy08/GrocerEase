namespace GrocerEase
{
    partial class Receipt
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
            btn_Cancel = new Button();
            btn_Print = new Button();
            lv_List = new ListView();
            panel1 = new Panel();
            btn_Exit = new Button();
            lbl_Title = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.AutoSize = true;
            btn_Cancel.BackColor = Color.Tomato;
            btn_Cancel.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(12, 781);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(190, 67);
            btn_Cancel.TabIndex = 16;
            btn_Cancel.Text = "CANCEL";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Print
            // 
            btn_Print.AutoSize = true;
            btn_Print.BackColor = Color.OliveDrab;
            btn_Print.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(405, 781);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(190, 67);
            btn_Print.TabIndex = 17;
            btn_Print.Text = "PRINT";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += Btn_Print_Click;
            // 
            // lv_List
            // 
            lv_List.BorderStyle = BorderStyle.None;
            lv_List.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_List.FullRowSelect = true;
            lv_List.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_List.Location = new Point(2, 167);
            lv_List.Name = "lv_List";
            lv_List.Size = new Size(602, 608);
            lv_List.TabIndex = 18;
            lv_List.UseCompatibleStateImageBehavior = false;
            lv_List.View = View.List;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 88, 110);
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(lbl_Title);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 61);
            panel1.TabIndex = 19;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Comfortaa", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(757, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(31, 33);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "X";
            btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Comfortaa", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(12, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(583, 58);
            lbl_Title.TabIndex = 8;
            lbl_Title.Text = "GrocerEase - Receipt";
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
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Comfortaa", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 64);
            label1.Name = "label1";
            label1.Size = new Size(602, 36);
            label1.TabIndex = 20;
            label1.Text = "GrocerEase";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 91);
            label2.Name = "label2";
            label2.Size = new Size(602, 36);
            label2.TabIndex = 21;
            label2.Text = "========================================================================";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 112);
            label3.Name = "label3";
            label3.Size = new Size(602, 36);
            label3.TabIndex = 22;
            label3.Text = "Receipt #:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 136);
            label4.Name = "label4";
            label4.Size = new Size(602, 36);
            label4.TabIndex = 23;
            label4.Text = "========================================================================";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 161, 175);
            ClientSize = new Size(607, 860);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lv_List);
            Controls.Add(btn_Print);
            Controls.Add(btn_Cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Cancel;
        private Button btn_Print;

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        private ListView lv_List;
        private Panel panel1;
        private Button btn_Exit;
        private Label lbl_Title;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}