using Sayra;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class UI : Form
    {
        string TabContent;

        public UI()
        {
            InitializeComponent();
            DatabaseManager.Initialize("Data Source=DESKTOP-BB2GC4I;Initial Catalog=db_GrocerEase;Integrated Security=True;Encrypt=False;");
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void Lbl_Products_Click(object sender, EventArgs e)
        {
            TabContent = "Products";
            UI_Load(sender, e);
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

        private void UI_Load(object sender, EventArgs e)
        {
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

                case "Users":
                    lbl_Users.BackColor = Color.SandyBrown;
                    lbl_Users.ForeColor = Color.White;
                    lbl_Users.BorderStyle = BorderStyle.None;
                    break;

                case "POS":
                    lbl_POS.BackColor = Color.SandyBrown;
                    lbl_POS.ForeColor = Color.White;
                    lbl_POS.BorderStyle = BorderStyle.None;
                    POS pos = new()
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
                    /*Dashboard dashboard = new()
                    {
                        TopLevel = false
                    };
                    pnl_Content.Controls.Add(dashboard);
                    dashboard.Show();*/
                    break;
            }
        }

        private void Lbl_POS_Click(object sender, EventArgs e)
        {
            TabContent = "POS";
            UI_Load(sender, e);
        }

        private void Lbl_Dashboard_Click(object sender, EventArgs e)
        {
            TabContent = "Dashboard";
            UI_Load(sender, e);
        }

        public void Lbl_Categories_Click(object sender, EventArgs e)
        {
            TabContent = "Categories";
            UI_Load(sender, e);
        }

        private void Lbl_Users_Click(object sender, EventArgs e)
        {
            TabContent = "Users";
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
