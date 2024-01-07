using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayra
{
    internal class FillReceipt
    {
        public static void ProcessReceipt(ListView lvBag)
        {
            List<string> itemsList = [];

            foreach (ListViewItem item in lvBag.Items)
            {
                string itemName = item.Text;
                string quantity = item.SubItems[1].Text.Replace("x", "");
                string totalPrice = item.SubItems[2].Text.Replace("₱", "");

                string itemDetails = $"{itemName} - Quantity: {quantity}, Total Price: ₱{totalPrice}";
                itemsList.Add(itemDetails);
            }
        }
    }
}
