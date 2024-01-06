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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lbl_Products = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            lbl_Inventory = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            lbl_OutOfStocks = new Label();
            label3 = new Label();
            t_DateTime = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold);
            lbl_Date.Location = new Point(12, 9);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(0, 52);
            lbl_Date.TabIndex = 0;
            // 
            // lbl_Time
            // 
            lbl_Time.Font = new Font("Comfortaa", 23.9999962F, FontStyle.Bold);
            lbl_Time.Location = new Point(702, 9);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.RightToLeft = RightToLeft.Yes;
            lbl_Time.Size = new Size(611, 52);
            lbl_Time.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(4, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1309, 708);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(71, 270);
            panel6.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Location = new Point(80, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 270);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(lbl_Products);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(263, 264);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Products
            // 
            lbl_Products.Font = new Font("Comfortaa", 50.2499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Products.ForeColor = Color.White;
            lbl_Products.Location = new Point(3, 74);
            lbl_Products.Name = "lbl_Products";
            lbl_Products.Size = new Size(257, 127);
            lbl_Products.TabIndex = 1;
            lbl_Products.Text = "0";
            lbl_Products.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Comfortaa", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 201);
            label2.Name = "label2";
            label2.Size = new Size(257, 50);
            label2.TabIndex = 2;
            label2.Text = "Products";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(356, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(71, 270);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(flowLayoutPanel4);
            panel3.Location = new Point(433, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 270);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(pictureBox3);
            flowLayoutPanel4.Controls.Add(lbl_Inventory);
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(4, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(263, 264);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lbl_Inventory
            // 
            lbl_Inventory.Font = new Font("Comfortaa", 50.2499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inventory.ForeColor = Color.White;
            lbl_Inventory.Location = new Point(3, 74);
            lbl_Inventory.Name = "lbl_Inventory";
            lbl_Inventory.Size = new Size(257, 127);
            lbl_Inventory.TabIndex = 1;
            lbl_Inventory.Text = "0";
            lbl_Inventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Comfortaa", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(257, 50);
            label5.TabIndex = 2;
            label5.Text = "Inventory";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(709, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(71, 270);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Tomato;
            panel5.Controls.Add(flowLayoutPanel3);
            panel5.Location = new Point(786, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 270);
            panel5.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(pictureBox2);
            flowLayoutPanel3.Controls.Add(lbl_OutOfStocks);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(4, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(263, 264);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbl_OutOfStocks
            // 
            lbl_OutOfStocks.Font = new Font("Comfortaa", 50.2499924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OutOfStocks.ForeColor = Color.White;
            lbl_OutOfStocks.Location = new Point(3, 74);
            lbl_OutOfStocks.Name = "lbl_OutOfStocks";
            lbl_OutOfStocks.Size = new Size(257, 127);
            lbl_OutOfStocks.TabIndex = 1;
            lbl_OutOfStocks.Text = "0";
            lbl_OutOfStocks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Comfortaa", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 201);
            label3.Name = "label3";
            label3.Size = new Size(257, 50);
            label3.TabIndex = 2;
            label3.Text = "Out of Stocks";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // t_DateTime
            // 
            t_DateTime.Enabled = true;
            t_DateTime.Interval = 1000;
            t_DateTime.Tick += DateTime_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 784);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Date);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Date;
        private Label lbl_Time;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer t_DateTime;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Label lbl_Products;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pictureBox3;
        private Label lbl_Inventory;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox2;
        private Label lbl_OutOfStocks;
        private Label label3;
        private Panel panel6;
    }
}