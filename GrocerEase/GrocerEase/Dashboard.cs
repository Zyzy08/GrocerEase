using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrocerEase
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=DESKTOP-BB2GC4I;Initial Catalog = db_GrocerEase; Integrated Security = True; Encrypt=False;";
        
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new(connectionString);
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

                    TabPage tabPageCategory = new()
                    {
                        Name = "Category" + categoryId,
                        Text = categoryName,
                        Size = new Size(819, 632)
                    };

                    string querySubcategories = "SELECT SubCategory_ID, SubCategory_Name FROM tbl_SubCategories WHERE Category_ID=@categoryId";
                    SqlDataAdapter adapterSubcategories = new(querySubcategories, connection);
                    adapterSubcategories.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                    DataTable subcategoriesTable = new();
                    adapterSubcategories.Fill(subcategoriesTable);

                    TabControl tcSubcategories = new()
                    {
                        Name = "tcSubcategories",
                        Dock = DockStyle.Fill
                    };

                    foreach (DataRow subcategoryRow in subcategoriesTable.Rows)
                    {
                        int subcategoryId = Convert.ToInt32(subcategoryRow["SubCategory_ID"]);
                        string? subcategoryName = subcategoryRow["SubCategory_Name"].ToString();

                        TabPage tabPageSubcategory = new()
                        {
                            Name = "Subcategory" + subcategoryId,
                            Text = subcategoryName,
                            Size = new Size(819, 602)
                        };

                        string queryItems = "SELECT Item_Name, Item_Icon FROM tbl_Items WHERE SubCategory_ID=@subcategoryId";
                        SqlDataAdapter adapterItems = new(queryItems, connection);
                        adapterItems.SelectCommand.Parameters.AddWithValue("@subcategoryId", subcategoryId);
                        DataTable itemsTable = new();
                        adapterItems.Fill(itemsTable);

                        FlowLayoutPanel flowLayoutPanelItems = new()
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
                                Text = itemRow["Item_Name"].ToString(),
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

                            flowLayoutPanelItems.Controls.Add(groupBoxItem);
                        }

                        tabPageSubcategory.Controls.Add(flowLayoutPanelItems);
                        tcSubcategories.TabPages.Add(tabPageSubcategory);
                    }

                    tabPageCategory.Controls.Add(tcSubcategories);
                    Dashboard_tcCategory.TabPages.Add(tabPageCategory);
                }
            }
        }
    }
}