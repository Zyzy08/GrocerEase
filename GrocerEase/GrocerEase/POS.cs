﻿using Sayra;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GrocerEase
{
    public partial class POS : Form
    {
        private DataRow selectedItemRow;

        private readonly int cashierID;

        public POS(int cashierID)
        {
            InitializeComponent();
            InitializeVATLabels();

            btn_Remove.Click += Btn_Remove_Click;
            tb_Search.TextChanged += Tb_Search_TextChanged;

            this.cashierID = cashierID;
        }

        private void InitializeVATLabels()
        {
            lv_Bag.View = View.Details;
            lv_Bag.Columns.Add("Item", -2, HorizontalAlignment.Left);
            lv_Bag.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            lv_Bag.Columns.Add("Price", -2, HorizontalAlignment.Left);
        }

        private void POS_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(DatabaseManager.ConnectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    DisplayDiscounts();

                    string queryCategories = "SELECT Category_ID, Category_Name FROM tbl_Categories";
                    SqlDataAdapter adapterCategories = new(queryCategories, connection);
                    DataTable categoriesTable = new();
                    adapterCategories.Fill(categoriesTable);

                    foreach (DataRow categoryRow in categoriesTable.Rows)
                    {
                        int categoryId = Convert.ToInt32(categoryRow["Category_ID"]);
                        string categoryName = categoryRow["Category_Name"].ToString();

                        TabPage tp_Category = new()
                        {
                            Name = "Category" + categoryId,
                            Text = categoryName,
                            Size = new Size(819, 632)
                        };

                        string queryItems = "SELECT Item_Name, Item_NetWT, Item_Icon, Item_Price, Item_InStock FROM tbl_Items WHERE Category_ID=@categoryId";
                        SqlDataAdapter adapterItems = new(queryItems, connection);
                        adapterItems.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                        DataTable itemsTable = new();
                        adapterItems.Fill(itemsTable);

                        FlowLayoutPanel flp_Category = new()
                        {
                            Name = "flowLayoutPanelCategory",
                            Dock = DockStyle.Fill,
                            FlowDirection = FlowDirection.LeftToRight,
                            AutoScroll = true
                        };

                        foreach (DataRow itemRow in itemsTable.Rows)
                        {
                            FlowLayoutPanel flp_Item = new()
                            {
                                Name = "flowLayoutPanelItem",
                                FlowDirection = FlowDirection.TopDown,
                                Size = new Size(200, 200),
                                Margin = new Padding(5)
                            };

                            PictureBox pb_ItemImage = new()
                            {
                                Name = "pb_ItemImage",
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Size = new Size(150, 100),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            if (Convert.ToInt32(itemRow["Item_InStock"]) > 0)
                            {
                                pb_ItemImage.Click += (pbSender, pbEvent) =>
                                {
                                    DisplayItemDetails(itemRow);
                                };
                            }

                            if (itemRow["Item_Icon"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])itemRow["Item_Icon"];
                                Image itemImage = ByteArrayToImage(imageBytes);
                                pb_ItemImage.Image = itemImage;
                            }
                            else
                            {
                                Label lbl_NoImage = new()
                                {
                                    Name = "lbl_NoImage",
                                    Text = "(no image)",
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    AutoSize = true,
                                    Dock = DockStyle.Top,
                                    ForeColor = Color.Gray
                                };

                                pb_ItemImage.Controls.Add(lbl_NoImage);
                            }

                            if (Convert.ToInt32(itemRow["Item_InStock"]) == 0)
                            {
                                Label lbl_OutOfStock = new()
                                {
                                    Name = "lbl_OutOfStock",
                                    Text = "(out of stock)",
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    AutoSize = true,
                                    Dock = DockStyle.Bottom,
                                    ForeColor = Color.Red
                                };

                                pb_ItemImage.Controls.Add(lbl_OutOfStock);
                            }

                            Label lbl_ItemDetails = new()
                            {
                                Name = "lbl_ItemDetails",
                                TextAlign = ContentAlignment.MiddleCenter,
                                AutoSize = true,
                                Text = $"{itemRow["Item_Name"]} ({itemRow["Item_NetWT"]})\nPrice: ₱{itemRow["Item_Price"]}\nIn-Stock: {itemRow["Item_InStock"]}"
                            };

                            lbl_ItemDetails.Click += (lblSender, lblEvent) =>
                            {
                                DisplayItemDetails(itemRow);
                            };

                            flp_Item.Controls.Add(pb_ItemImage);
                            flp_Item.Controls.Add(lbl_ItemDetails);
                            flp_Category.Controls.Add(flp_Item);
                        }

                        tp_Category.Controls.Add(flp_Category);
                        tc_Categories.TabPages.Add(tp_Category);
                    }
                }
            }

            UpdateVATCalculations();

            lv_Bag.SelectedIndexChanged += Lv_Bag_SelectedIndexChanged;
        }

        private void DisplayDiscounts()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryDiscounts = "SELECT Discount_ID, Discount_Type, Discount_Rate, IsActive FROM tbl_Discounts";
                SqlDataAdapter adapterDiscounts = new(queryDiscounts, connection);
                DataTable discountsTable = new();
                adapterDiscounts.Fill(discountsTable);

                foreach (DataRow discountRow in discountsTable.Rows)
                {
                    int discountId = Convert.ToInt32(discountRow["Discount_ID"]);
                    string discountType = discountRow["Discount_Type"].ToString();
                    decimal discountRate = Convert.ToDecimal(discountRow["Discount_Rate"]);
                    bool isActive = Convert.ToBoolean(discountRow["IsActive"]);

                    FlowLayoutPanel flp_Discount = new()
                    {
                        Name = "flp_Discount",
                        FlowDirection = FlowDirection.TopDown,
                        Size = new Size(200, 50),
                        Margin = new Padding(5),
                        AutoSize = true
                    };

                    CheckBox chk_IsActive = new()
                    {
                        Name = "chk_IsActive",
                        Text = " ",
                        Appearance = Appearance.Button,
                        BackColor = System.Drawing.Color.Transparent,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance =
                        {
                            BorderSize = 0,
                            CheckedBackColor = System.Drawing.Color.Transparent
                        },
                        Size = new Size(42, 27),
                        Checked = isActive,
                        BackgroundImage = isActive ? Sayra.Properties.Resources.Toggle_Button_Enabled : Sayra.Properties.Resources.Toggle_Button_Disabled,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Tag = discountId
                    };

                    Label lbl_DiscountDetails = new()
                    {
                        Name = "lbl_DiscountDetails",
                        Text = $"{discountType} ({discountRate}%)",
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true,
                        Font = new Font("Comfortaa", 12),
                        ForeColor = isActive ? SystemColors.ControlText : SystemColors.GrayText
                    };

                    flp_Discount.Controls.Add(chk_IsActive);
                    flp_Discount.Controls.Add(lbl_DiscountDetails);

                    flp_Discounts.Controls.Add(flp_Discount);

                    chk_IsActive.CheckedChanged += (sender, e) =>
                    {
                        bool newIsActive = ((CheckBox)sender).Checked;
                        int currentDiscountId = (int)((CheckBox)sender).Tag;

                        UpdateDiscountStatus(currentDiscountId, newIsActive);

                        lbl_DiscountDetails.ForeColor = newIsActive ? SystemColors.ControlText : SystemColors.GrayText;
                        chk_IsActive.BackgroundImage = newIsActive ? Sayra.Properties.Resources.Toggle_Button_Enabled : Sayra.Properties.Resources.Toggle_Button_Disabled;

                        UpdateVATCalculations();
                    };

                    chk_IsActive.Invalidate();
                }
            }
        }

        private static void UpdateDiscountStatus(int discountId, bool newStatus)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string updateQuery = "UPDATE tbl_Discounts SET IsActive = @IsActive WHERE Discount_ID = @DiscountID";

                using SqlCommand updateCommand = new(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@IsActive", newStatus);
                updateCommand.Parameters.AddWithValue("@DiscountID", discountId);

                updateCommand.ExecuteNonQuery();
            }
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using MemoryStream ms = new(byteArray);
            Image image = Image.FromStream(ms);
            return image;
        }

        private void Nud_Quantity_ValueChanged(object sender, EventArgs e)
        {
            if (selectedItemRow != null)
            {
                decimal itemPrice = Convert.ToDecimal(selectedItemRow["Item_Price"]);
                int quantity = (int)nud_Quantity.Value;

                decimal totalPrice = itemPrice * quantity;

                lbl_Price.Text = $"Price: ₱{totalPrice:N2}";
            }
        }

        private void DisplayItemDetails(DataRow itemRow)
        {
            var itemName = itemRow["Item_Name"].ToString();
            var itemNetWT = itemRow["Item_NetWT"].ToString();
            decimal itemPrice = Convert.ToDecimal(itemRow["Item_Price"]);
            int itemInStock = Convert.ToInt32(itemRow["Item_InStock"]);

            selectedItemRow = itemRow;

            lbl_Name.Text = $"Item: {itemName} ({itemNetWT})";
            lbl_Price.Text = $"Price: ₱{itemPrice:N2}";

            nud_Quantity.Value = 1;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (selectedItemRow != null)
            {
                var itemName = selectedItemRow["Item_Name"].ToString();
                decimal itemPrice = Convert.ToDecimal(selectedItemRow["Item_Price"]);
                int itemInStock = Convert.ToInt32(selectedItemRow["Item_InStock"]);
                int quantity = (int)nud_Quantity.Value;

                if (quantity <= itemInStock)
                {
                    bool itemExists = false;

                    foreach (ListViewItem item in lv_Bag.Items)
                    {
                        if (item.Text == itemName)
                        {
                            int existingQuantity = int.Parse(item.SubItems[1].Text.Replace("x", ""));

                            if (existingQuantity + quantity > itemInStock)
                            {
                                MessageBox.Show($"Quantity exceeds the in-stock for this item. In-Stock: {itemInStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            existingQuantity += quantity;
                            item.SubItems[1].Text = $"x{existingQuantity}";

                            decimal existingTotalPrice = decimal.Parse(item.SubItems[2].Text.Replace("₱", ""));
                            existingTotalPrice += itemPrice * quantity;
                            item.SubItems[2].Text = $"₱{existingTotalPrice:N2}";

                            itemExists = true;
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        ListViewItem item = new(itemName);
                        item.SubItems.Add($"x{quantity}");
                        item.SubItems.Add($"₱{itemPrice * quantity:N2}");

                        lv_Bag.Items.Add(item);
                    }

                    lv_Bag.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lv_Bag.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    UpdateVATCalculations();

                    btn_Pay.Enabled = lv_Bag.Items.Count > 0;
                }
                else
                {
                    MessageBox.Show($"Quantity exceeds the in-stock for this item. In-Stock: {itemInStock}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateVATCalculations()
        {
            decimal totalSale = CalculateTotalSale();
            decimal vat = totalSale * 0.12m;

            lbl_Subtotal.Text = $"₱{totalSale:N2}";

            decimal discountedTotalSale = ApplyDiscounts(totalSale);

            decimal discountAmount = totalSale - discountedTotalSale;

            lbl_Discounts.Text = $"₱{discountAmount:N2}-";

            decimal total = discountedTotalSale + vat;
            lbl_VAT.Text = $"₱{vat:N2}";
            lbl_Total.Text = $"{total:N2}";
        }

        private decimal ApplyDiscounts(decimal totalSale)
        {
            decimal discountedTotalSale = totalSale;

            foreach (Control control in flp_Discounts.Controls)
            {
                if (control is FlowLayoutPanel flp_Discount)
                {
                    CheckBox chk_IsActive = flp_Discount.Controls.OfType<CheckBox>().FirstOrDefault();
                    Label lbl_DiscountDetails = flp_Discount.Controls.OfType<Label>().FirstOrDefault();

                    if (chk_IsActive != null && lbl_DiscountDetails != null)
                    {
                        if (chk_IsActive.Checked)
                        {
                            string discountRateText = lbl_DiscountDetails.Text.Split('(')[1].Split('%')[0];
                            decimal discountRate = Convert.ToDecimal(discountRateText);

                            discountedTotalSale *= (1 - (discountRate / 100));
                        }
                    }
                }
            }

            return discountedTotalSale;
        }

        private decimal CalculateTotalSale()
        {
            decimal totalSale = 0;

            foreach (ListViewItem item in lv_Bag.Items)
            {
                string totalPriceText = item.SubItems[2].Text.Replace("₱", "");
                totalSale += decimal.Parse(totalPriceText);
            }

            return totalSale;
        }

        private void Lv_Bag_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Remove.Visible = lv_Bag.SelectedItems.Count > 0;
            btn_Pay.Visible = lv_Bag.SelectedItems.Count == 0;
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lv_Bag.SelectedItems)
            {
                lv_Bag.Items.Remove(selectedItem);
            }

            UpdateVATCalculations();
            btn_Pay.Enabled = lv_Bag.Items.Count > 0;
            btn_Pay.Visible = lv_Bag.SelectedItems.Count == 0;
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            if (lv_Bag.Items.Count > 0)
            {
                StoreItemsInTempList();

                Checkout checkout = new(lbl_Subtotal, lbl_VAT, lbl_Discounts, lbl_Total, cashierID);
                checkout.ShowDialog();
            }
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text.Trim().ToLower();

            foreach (TabPage tabPage in tc_Categories.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is FlowLayoutPanel flp_Category)
                    {
                        foreach (Control flpItemControl in flp_Category.Controls)
                        {
                            if (flpItemControl is FlowLayoutPanel flp_Item)
                            {
                                if (flp_Item.Controls.Count >= 2 && flp_Item.Controls[1] is Label lbl_ItemDetails)
                                {
                                    string itemDetails = lbl_ItemDetails.Text.ToLower();

                                    if (itemDetails.Contains(searchText))
                                    {
                                        flp_Item.Visible = true;
                                    }
                                    else
                                    {
                                        flp_Item.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void StoreItemsInTempList()
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string clearTempListQuery = "DELETE FROM tbl_TempList";
                using (SqlCommand clearTempListCommand = new(clearTempListQuery, connection))
                {
                    clearTempListCommand.ExecuteNonQuery();
                }

                string insertTempListQuery = "INSERT INTO tbl_TempList (Item, Quantity, Price) VALUES (@ItemName, @Quantity, @Price)";
                using SqlCommand insertTempListCommand = new(insertTempListQuery, connection);
                foreach (ListViewItem item in lv_Bag.Items)
                {
                    string itemName = item.Text;
                    int quantity = int.Parse(item.SubItems[1].Text.Replace("x", ""));
                    decimal price = decimal.Parse(item.SubItems[2].Text.Replace("₱", ""));

                    insertTempListCommand.Parameters.Clear();
                    insertTempListCommand.Parameters.AddWithValue("@ItemName", itemName);
                    insertTempListCommand.Parameters.AddWithValue("@Quantity", quantity);
                    insertTempListCommand.Parameters.AddWithValue("@Price", price);

                    insertTempListCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
