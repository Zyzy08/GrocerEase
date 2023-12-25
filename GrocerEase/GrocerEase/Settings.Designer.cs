namespace GrocerEase
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            btn_Back = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            tc_Settings = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            StockManagement_btn_Add = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            toolStripContainer1 = new ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)btn_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tc_Settings.SuspendLayout();
            tabPage2.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Location = new Point(-9, -14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 58);
            panel1.TabIndex = 10;
            // 
            // btn_Back
            // 
            btn_Back.Image = (Image)resources.GetObject("btn_Back.Image");
            btn_Back.Location = new Point(54, 50);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(45, 43);
            btn_Back.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Back.TabIndex = 9;
            btn_Back.TabStop = false;
            btn_Back.Click += Btn_Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(1416, 710);
            panel4.TabIndex = 13;
            // 
            // tc_Settings
            // 
            tc_Settings.Controls.Add(tabPage1);
            tc_Settings.Controls.Add(tabPage2);
            tc_Settings.Controls.Add(tabPage3);
            tc_Settings.Controls.Add(tabPage4);
            tc_Settings.Controls.Add(tabPage5);
            tc_Settings.Controls.Add(tabPage6);
            tc_Settings.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tc_Settings.Location = new Point(3, 99);
            tc_Settings.Name = "tc_Settings";
            tc_Settings.SelectedIndex = 0;
            tc_Settings.Size = new Size(1416, 710);
            tc_Settings.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 95);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1408, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tab1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(StockManagement_btn_Add);
            tabPage2.Location = new Point(4, 95);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1408, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tab2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StockManagement_btn_Add
            // 
            StockManagement_btn_Add.Location = new Point(390, 424);
            StockManagement_btn_Add.Name = "StockManagement_btn_Add";
            StockManagement_btn_Add.Size = new Size(273, 104);
            StockManagement_btn_Add.TabIndex = 0;
            StockManagement_btn_Add.Text = "+ Add";
            StockManagement_btn_Add.UseVisualStyleBackColor = true;
            StockManagement_btn_Add.Click += StockManagement_btn_Add_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 95);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1408, 611);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tab3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 95);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1408, 611);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tab4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 95);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1408, 611);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tab5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 95);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1408, 611);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tab6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.AutoScroll = true;
            toolStripContainer1.ContentPanel.Controls.Add(tc_Settings);
            toolStripContainer1.ContentPanel.Controls.Add(panel4);
            toolStripContainer1.ContentPanel.Controls.Add(panel1);
            toolStripContainer1.ContentPanel.Controls.Add(btn_Back);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox1);
            toolStripContainer1.ContentPanel.Size = new Size(1424, 821);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1424, 821);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 821);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tc_Settings.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox btn_Back;
        private PictureBox pictureBox1;
        private Panel panel4;
        private TabControl tc_Settings;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button StockManagement_btn_Add;
        private ToolStripContainer toolStripContainer1;
    }
}