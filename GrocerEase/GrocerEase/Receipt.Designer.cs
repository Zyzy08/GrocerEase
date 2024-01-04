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
            lv_Bag = new ListView();
            SuspendLayout();
            // 
            // lv_Bag
            // 
            lv_Bag.Font = new Font("Comfortaa Medium", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_Bag.FullRowSelect = true;
            lv_Bag.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_Bag.Location = new Point(3, 12);
            lv_Bag.Name = "lv_Bag";
            lv_Bag.Size = new Size(601, 591);
            lv_Bag.TabIndex = 15;
            lv_Bag.UseCompatibleStateImageBehavior = false;
            lv_Bag.View = View.List;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 699);
            Controls.Add(lv_Bag);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Bag;
    }
}