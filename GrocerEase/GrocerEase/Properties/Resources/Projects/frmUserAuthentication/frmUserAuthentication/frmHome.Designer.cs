namespace frmUserAuthentication
{
    partial class frmHome
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
            this.btnAddUserAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUserAdmin
            // 
            this.btnAddUserAdmin.Location = new System.Drawing.Point(12, 137);
            this.btnAddUserAdmin.Name = "btnAddUserAdmin";
            this.btnAddUserAdmin.Size = new System.Drawing.Size(116, 44);
            this.btnAddUserAdmin.TabIndex = 0;
            this.btnAddUserAdmin.Text = "Add User/Admin";
            this.btnAddUserAdmin.UseVisualStyleBackColor = true;
            this.btnAddUserAdmin.Click += new System.EventHandler(this.btnAddUserAdmin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(330, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 212);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddUserAdmin);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUserAdmin;
        private System.Windows.Forms.Button btnLogout;
    }
}