namespace GrocerEase
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Dashboard_tcCategory = new TabControl();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Settings = new PictureBox();
            panel1 = new Panel();
            Dashboard_btnAdd = new Button();
            panel2 = new Panel();
            lbl_Price = new Label();
            label1 = new Label();
            Dashboard_nudQuantity = new NumericUpDown();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dashboard_nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // Dashboard_tcCategory
            // 
            Dashboard_tcCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_tcCategory.Location = new Point(3, 3);
            Dashboard_tcCategory.Name = "Dashboard_tcCategory";
            Dashboard_tcCategory.SelectedIndex = 0;
            Dashboard_tcCategory.Size = new Size(862, 666);
            Dashboard_tcCategory.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 29);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_Settings
            // 
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.Location = new Point(835, 64);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(45, 43);
            btn_Settings.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Settings.TabIndex = 3;
            btn_Settings.TabStop = false;
            btn_Settings.Click += Btn_Settings_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 58);
            panel1.TabIndex = 4;
            // 
            // Dashboard_btnAdd
            // 
            Dashboard_btnAdd.AutoSize = true;
            Dashboard_btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_btnAdd.Location = new Point(689, 671);
            Dashboard_btnAdd.Name = "Dashboard_btnAdd";
            Dashboard_btnAdd.Size = new Size(134, 60);
            Dashboard_btnAdd.TabIndex = 1;
            Dashboard_btnAdd.Text = "+ ADD";
            Dashboard_btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_Price);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Dashboard_nudQuantity);
            panel2.Controls.Add(Dashboard_tcCategory);
            panel2.Controls.Add(Dashboard_btnAdd);
            panel2.Location = new Point(12, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 735);
            panel2.TabIndex = 5;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(3, 702);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(63, 30);
            lbl_Price.TabIndex = 4;
            lbl_Price.Text = "₱0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 672);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 3;
            label1.Text = "Price / EA:";
            // 
            // Dashboard_nudQuantity
            // 
            Dashboard_nudQuantity.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_nudQuantity.Location = new Point(547, 681);
            Dashboard_nudQuantity.Name = "Dashboard_nudQuantity";
            Dashboard_nudQuantity.Size = new Size(136, 43);
            Dashboard_nudQuantity.TabIndex = 2;
            Dashboard_nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel3
            // 
            panel3.Location = new Point(886, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(542, 784);
            panel3.TabIndex = 6;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 860);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Settings);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dashboard_nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl Dashboard_tcCategory;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox btn_Settings;
        private Panel panel1;
        private Button Dashboard_btnAdd;
        private Panel panel2;
        private NumericUpDown Dashboard_nudQuantity;
        private Label lbl_Price;
        private Label label1;
        private Panel panel3;
    }
}