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
            List<string> itemsList = new List<string>();

            foreach (ListViewItem item in lvBag.Items)
            {
                string itemName = item.Text;
                string quantity = item.SubItems[1].Text.Replace("x", "");
                string totalPrice = item.SubItems[2].Text.Replace("₱", "");

                string itemDetails = $"{itemName} - Quantity: {quantity}, Total Price: ₱{totalPrice}";
                itemsList.Add(itemDetails);
            }

            // Add code to handle the receipt processing using the list of items
            // This could involve saving it to a file, sending it to a printer, etc.
            // For now, let's just print to the console as an example
            Console.WriteLine("Receipt processed:");
            foreach (var item in itemsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
