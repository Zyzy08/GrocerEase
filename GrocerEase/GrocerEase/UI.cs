﻿using Sayra;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class UI : Form
    {
        string TabContent;

        private readonly Login.EmployeeData employeeData;

        private readonly int cashierID;

        public UI(Login.EmployeeData employeeData)
        {
            InitializeComponent();
            this.employeeData = employeeData;
            cashierID = employeeData.EmployeeID;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void RefreshProductsForm()
        {
            foreach (Control control in pnl_Content.Controls)
            {
                if (control is Products products)
                {
                    products.RefreshData();
                    break;
                }
            }
        }

        public void RefreshCategoriesForm()
        {
            foreach (Control control in pnl_Content.Controls)
            {
                if (control is Categories categories)
                {
                    categories.RefreshData();
                    break;
                }
            }
        }

        public void RefreshDiscountsForm()
        {
            foreach (Control control in pnl_Content.Controls)
            {
                if (control is Discounts discounts)
                {
                    discounts.RefreshData();
                    break;
                }
            }
        }

        public void RefreshUsersForm()
        {
            foreach (Control control in pnl_Content.Controls)
            {
                if (control is Users users)
                {
                    users.RefreshData();
                    break;
                }
            }
        }

        private void UI_Load(object sender, EventArgs e)
        {
            DisableAllTabs();

            EnableTabsBasedOnRole();

            pnl_Content.Controls.Clear();

            foreach (Control control in flp_Tabs.Controls)
            {
                if (control is Label label && control.Tag != null && control.Tag.ToString() == "Tab")
                {
                    Label tabLabel = label;
                    tabLabel.BackColor = SystemColors.Control;
                    tabLabel.ForeColor = Color.SandyBrown;
                    tabLabel.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            switch (TabContent)
            {
                case "Products":
                    lbl_Products.BackColor = Color.SandyBrown;
                    lbl_Products.ForeColor = Color.White;
                    lbl_Products.BorderStyle = BorderStyle.None;
                    Products products = new()
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(products);
                    products.Show();
                    break;

                case "Categories":
                    lbl_Categories.BackColor = Color.SandyBrown;
                    lbl_Categories.ForeColor = Color.White;
                    lbl_Categories.BorderStyle = BorderStyle.None;
                    Categories categories = new()
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(categories);
                    categories.Show();
                    break;

                case "Discounts":
                    lbl_Discounts.BackColor = Color.SandyBrown;
                    lbl_Discounts.ForeColor = Color.White;
                    lbl_Discounts.BorderStyle = BorderStyle.None;
                    Discounts discounts = new()
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(discounts);
                    discounts.Show();
                    break;

                case "Users":
                    lbl_Users.BackColor = Color.SandyBrown;
                    lbl_Users.ForeColor = Color.White;
                    lbl_Users.BorderStyle = BorderStyle.None;
                    Users users = new(cashierID)
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(users);
                    users.Show();
                    break;

                case "POS":
                    lbl_POS.BackColor = Color.SandyBrown;
                    lbl_POS.ForeColor = Color.White;
                    lbl_POS.BorderStyle = BorderStyle.None;
                    POS pos = new(cashierID)
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(pos);
                    pos.Show();
                    break;

                default:
                    lbl_Dashboard.BackColor = Color.SandyBrown;
                    lbl_Dashboard.ForeColor = Color.White;
                    lbl_Dashboard.BorderStyle = BorderStyle.None;
                    Dashboard dashboard = new()
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(dashboard);
                    dashboard.Show();
                    break;
            }
        }

        private void EnableTabsBasedOnRole()
        {
            switch (employeeData.Role)
            {
                case "Cashier":
                    lbl_POS.Enabled = true;
                    TabContent = "POS";
                    break;
                default:
                    EnableAllTabs();
                    break;
            }
        }

        private void DisableAllTabs()
        {
            foreach (Control control in flp_Tabs.Controls)
            {
                if (control is Label label && label.Tag != null && label.Tag.ToString() == "Tab")
                {
                    label.Enabled = false;
                }
            }
        }

        private void EnableAllTabs()
        {
            foreach (Control control in flp_Tabs.Controls)
            {
                if (control is Label label && label.Tag != null && label.Tag.ToString() == "Tab")
                {
                    label.Enabled = true;
                }
            }
        }

        private void Lbl_Dashboard_Click(object sender, EventArgs e)
        {
            TabContent = "Dashboard";
            lbl_Title.Text = "GrocerEase - Dashboard";
            Text = "Dashboard";
            UI_Load(sender, e);
        }

        public void Lbl_Products_Click(object sender, EventArgs e)
        {
            TabContent = "Products";
            lbl_Title.Text = "GrocerEase - Products";
            Text = "Products";
            UI_Load(sender, e);
        }

        public void Lbl_Categories_Click(object sender, EventArgs e)
        {
            TabContent = "Categories";
            lbl_Title.Text = "GrocerEase - Categories";
            Text = "Categories";
            UI_Load(sender, e);
        }

        public void Lbl_Discounts_Click(object sender, EventArgs e)
        {
            TabContent = "Discounts";
            lbl_Title.Text = "GrocerEase - Discounts";
            Text = "Discounts";
            UI_Load(sender, e);
        }

        public void Lbl_Users_Click(object sender, EventArgs e)
        {
            TabContent = "Users";
            lbl_Title.Text = "GrocerEase - Users";
            Text = "Users";
            UI_Load(sender, e);
        }

        private void Lbl_POS_Click(object sender, EventArgs e)
        {
            TabContent = "POS";
            lbl_Title.Text = "GrocerEase - POS";
            Text = "POS";
            UI_Load(sender, e);
        }

        private void Lbl_Logout_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Close();
        }
    }
}
