using System.Data;
using System.Data.SqlClient;

namespace GrocerEase
{
    public partial class POS : Form
    {

        private DataRow selectedItemRow;

        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new(DatabaseManager.ConnectionString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                string queryCategories = "SELECT Category_ID, Category_Name FROM tbl_Categories";
                SqlDataAdapter adapterCategories = new(queryCategories, connection);
                DataTable categoriesTable = new();
                adapterCategories.Fill(categoriesTable);

                foreach (DataRow categoryRow in categoriesTable.Rows)
                {
                    int categoryId = Convert.ToInt32(categoryRow["Category_ID"]);
                    string? categoryName = categoryRow["Category_Name"].ToString();

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
                            Text = $"{itemRow["Item_Name"]} ({itemRow["Item_NetWT"]})\nPrice: {itemRow["Item_Price"]}",
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = true
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

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using MemoryStream ms = new(byteArray);
            Image image = Image.FromStream(ms);
            return image;
        }

        private void DisplayItemDetails(DataRow itemRow)
        {
            var itemName = itemRow["Item_Name"].ToString();
            var itemNetWT = itemRow["Item_NetWT"].ToString();
            decimal itemPrice = Convert.ToDecimal(itemRow["Item_Price"]);

            selectedItemRow = itemRow;

            lbl_Name.Text = $"Name: {itemName} ({itemNetWT})";
            lbl_Price.Text = $"Price: ₱{itemPrice:N2}";

            nud_Quantity.Value = 1;
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

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (selectedItemRow != null)
            {
                var itemName = selectedItemRow["Item_Name"].ToString();
                var itemNetWT = selectedItemRow["Item_NetWT"].ToString();
                decimal itemPrice = Convert.ToDecimal(selectedItemRow["Item_Price"]);
                int quantity = (int)nud_Quantity.Value;

                decimal totalPrice = itemPrice * quantity;

                Label lbl_ItemDetails= new()
                {
                    Text = itemName + " (" + itemNetWT + ")",
                    AutoSize = true
                };

                Label lbl_Quantity = new()
                {
                    Text = $"x{quantity}",
                    AutoSize = true
                };

                Label lbl_TotalPrice = new()
                {
                    Text = $"₱{totalPrice:N2}",
                    AutoSize = true
                };

                tlp_Bag.RowCount++;
                tlp_Bag.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tlp_Bag.Controls.Add(lbl_ItemDetails, 0, tlp_Bag.RowCount - 1);
                tlp_Bag.Controls.Add(lbl_Quantity, 1, tlp_Bag.RowCount - 1);
                tlp_Bag.Controls.Add(lbl_TotalPrice, 2, tlp_Bag.RowCount - 1);
            }
        }
    }
}
