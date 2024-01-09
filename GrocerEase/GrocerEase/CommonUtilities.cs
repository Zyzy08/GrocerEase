using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sayra
{
    internal class CommonUtilities
    {
        public bool completed = false;

        public static void UpdateCategoryInStock(SqlConnection connection)
        {
            string updateCategoryInStockQuery = @"
                UPDATE tbl_Categories 
                SET InStock = (
                    SELECT SUM(Item_InStock) 
                    FROM tbl_Items 
                    WHERE tbl_Items.Category_ID = tbl_Categories.Category_ID)";

            using SqlCommand updateCommand = new(updateCategoryInStockQuery, connection);
            updateCommand.ExecuteNonQuery();
        }

        public void SetIsTransactionCompleted(bool completed)
        {
            this.completed = completed;
        }
    }
}
