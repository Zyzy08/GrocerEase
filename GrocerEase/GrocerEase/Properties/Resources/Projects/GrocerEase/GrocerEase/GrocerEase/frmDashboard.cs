using System;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace GrocerEase
{
    public partial class frmDashboard : Form
    {
        private Timer timer;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public frmDashboard()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 52);
            panelMenu.Controls.Add(leftBorderBtn);


            int totalButtons = panelMenu.Controls.OfType<IconButton>().Count();

            // Subtract 1
            int result = totalButtons - 1;

            // Update the label text
            lblCategories.Text = $"{result}";
        }

        private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCart.ScrollAlwaysVisible = true;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(79, 111, 82);
        }
        private void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(157, 192, 139);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(157, 192, 139);
                currentBtn.ForeColor = Color.FromArgb(79, 111, 82);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(79, 111, 82);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = currentBtn.Text;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmFood());
        }

        private void btnBev_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmBeverages());
        }

        private void btnAlco_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmAlcoholicDrinks());
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmHealthAndBeauty());
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmMotherAndBaby());
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmPetSupplies());
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmHousehold());
        }

        private void btnTobacco_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTobacco());
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(79, 111, 82);
            lblTitleChildForm.Text = "Home";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEditCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDiscount());


        }

        private double subTotal = 1000; // Replace this with your actual total amount

        private void btnOpenDiscountForm_Click(object sender, EventArgs e)
        {
            using (frmDiscount discountForm = new frmDiscount())
            {
                discountForm.ShowDialog();

                // Access selected values from the discount form
                string selectedDiscount = discountForm.SelectedDiscountType;
                string selectedPromotion = discountForm.SelectedPromotion;
                string selectedPaymentMode = discountForm.SelectedPaymentMode;

                // Update labels in FrmDashboard
                lblDiscount.Text = $"{selectedDiscount}";
                lblPromotion.Text = $"{selectedPromotion}";
                lblPaymentMode.Text = $"{selectedPaymentMode}";

                // Calculate and update total due based on selected discount and promotion
                UpdateTotalDue(selectedDiscount, selectedPromotion);
    }
        }

        private void UpdateTotalDue(string selectedDiscount, string selectedPromotion)
        {
            // Convert discount percentage to a multiplier
            double discountMultiplier = GetDiscountMultiplier(selectedDiscount);

            // Apply discount
            double discountedAmount = subTotal * (1 - discountMultiplier);

            // Apply promotion
            double discountedPromotionAmount = ApplyPromotion(discountedAmount, selectedPromotion);

            // Update the total due label
            lblTotalDue.Text = $"Total Due: {discountedPromotionAmount:C}";
        }
        private double GetDiscountMultiplier(string discountType)
        {
            // Implement logic to get discount multiplier based on the selected discount type
            switch (discountType)
            {
                case "Senior Citizen":
                case "PWD":
                    return 0.05; // 5% off for senior citizen and PWD
                default:
                    return 0.0; // No discount for other types
            }
        }

        private double ApplyPromotion(double amount, string promotionType)
        {
            // Implement logic to apply promotion based on the selected promotion type
            switch (promotionType)
            {
                case "BOGO":
                    return amount * 0.0; // 50%*2 off for BOGO
                case "Daily Promo":
                    return amount * 0.1; // 10% off for Daily Promo
                case "Bundle Deals":
                    return amount * 0.2; // 20% off for Bundle Deals
                case "Flash Sale":
                    return amount * 0.3; // 30% off for Flash Sale
                case "Season":
                    return amount * 0.5; // 50% off for Season
                default:
                    return amount; // No promotion for other types
            }
        }
    }
}