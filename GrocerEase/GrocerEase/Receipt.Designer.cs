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
            lv_Bag = new ListView();
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
            // 
            // lv_Bag
            // 
            lv_Bag.Font = new Font("Comfortaa", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_Bag.FullRowSelect = true;
            lv_Bag.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_Bag.Location = new Point(2, 2);
            lv_Bag.Name = "lv_Bag";
            lv_Bag.Size = new Size(602, 773);
            lv_Bag.TabIndex = 18;
            lv_Bag.UseCompatibleStateImageBehavior = false;
            lv_Bag.View = View.List;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 860);
            Controls.Add(lv_Bag);
            Controls.Add(btn_Print);
            Controls.Add(btn_Cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
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

        private ListView lv_Bag;
    }
}