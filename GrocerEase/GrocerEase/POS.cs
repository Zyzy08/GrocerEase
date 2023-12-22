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
        public POS()
        {
            InitializeComponent();
            DatabaseManager.Initialize("Data Source=DESKTOP-BB2GC4I;Initial Catalog=db_GrocerEase;Integrated Security=True;Encrypt=False;");
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new();
            this.Hide();
            settings.ShowDialog();
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using MemoryStream ms = new(byteArray);
            Image image = Image.FromStream(ms);
            return image;
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

                    string queryItems = "SELECT Item_Name, Item_NetWT, Item_Icon FROM tbl_Items WHERE Category_ID=@categoryId";
                    SqlDataAdapter adapterItems = new(queryItems, connection);
                    adapterItems.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                    DataTable itemsTable = new();
                    adapterItems.Fill(itemsTable);

                    FlowLayoutPanel flp_Items = new()
                    {
                        Name = "flowLayoutPanelItems",
                        Dock = DockStyle.Fill,
                        FlowDirection = FlowDirection.LeftToRight,
                        AutoScroll = true
                    };

                    foreach (DataRow itemRow in itemsTable.Rows)
                    {
                        GroupBox groupBoxItem = new()
                        {
                            Name = "Item" + itemRow["Item_Name"].ToString(),
                            Text = itemRow["Item_Name"].ToString() + " " + itemRow["Item_NetWT"].ToString(),
                            Size = new Size(200, 143),
                            BackgroundImageLayout = ImageLayout.Zoom
                        };

                        if (itemRow["Item_Icon"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])itemRow["Item_Icon"];
                            Image itemImage = ByteArrayToImage(imageBytes);
                            groupBoxItem.BackgroundImage = itemImage;
                        }
                        else
                        {
                            groupBoxItem.Text += " (No Image)";
                        }

                        flp_Items.Controls.Add(groupBoxItem);
                    }

                    tp_Category.Controls.Add(flp_Items);
                    tc_Categories.TabPages.Add(tp_Category);
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
