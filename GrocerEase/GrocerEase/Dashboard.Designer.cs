namespace Sayra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lbl_Date = new Label();
            lbl_Time = new Label();
            t_DateTime = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbl_Products = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            lbl_Inventory = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Comfortaa", 27.7499962F, FontStyle.Bold);
            lbl_Date.Location = new Point(12, 9);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(0, 60);
            lbl_Date.TabIndex = 0;
            // 
            // lbl_Time
            // 
            lbl_Time.Font = new Font("Comfortaa", 27.7499962F, FontStyle.Bold);
            lbl_Time.Location = new Point(756, 9);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.RightToLeft = RightToLeft.Yes;
            lbl_Time.Size = new Size(515, 60);
            lbl_Time.TabIndex = 1;
            // 
            // t_DateTime
            // 
            t_DateTime.Enabled = true;
            t_DateTime.Interval = 1000;
            t_DateTime.Tick += DateTime_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LimeGreen;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(4, 72);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1274, 700);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 243);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(lbl_Products);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(232, 237);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lbl_Products
            // 
            lbl_Products.Font = new Font("Comfortaa", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Products.ForeColor = Color.White;
            lbl_Products.Location = new Point(3, 40);
            lbl_Products.Name = "lbl_Products";
            lbl_Products.Size = new Size(229, 143);
            lbl_Products.TabIndex = 4;
            lbl_Products.Text = "0";
            lbl_Products.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 183);
            label2.Name = "label2";
            label2.Size = new Size(229, 39);
            label2.TabIndex = 5;
            label2.Text = "Products";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(248, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 243);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(flowLayoutPanel4);
            panel3.Location = new Point(493, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 243);
            panel3.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.BackColor = Color.CornflowerBlue;
            flowLayoutPanel4.Controls.Add(pictureBox3);
            flowLayoutPanel4.Controls.Add(lbl_Inventory);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(4, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(271, 383);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.CornflowerBlue;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lbl_Inventory
            // 
            lbl_Inventory.BackColor = Color.CornflowerBlue;
            lbl_Inventory.Font = new Font("Comfortaa", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inventory.ForeColor = Color.White;
            lbl_Inventory.Location = new Point(3, 40);
            lbl_Inventory.Name = "lbl_Inventory";
            lbl_Inventory.Size = new Size(229, 143);
            lbl_Inventory.TabIndex = 4;
            lbl_Inventory.Text = "0";
            lbl_Inventory.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 183);
            label4.Name = "label4";
            label4.Size = new Size(229, 39);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 784);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Date);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Date;
        private Label lbl_Time;
        private System.Windows.Forms.Timer t_DateTime;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lbl_Products;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox3;
        private Label lbl_Inventory;
        private Label label4;
    }
}