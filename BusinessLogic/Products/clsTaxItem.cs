using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogic.Users;

namespace BusinessLogic.Products
{
    public class clsTaxItem
    {
        public int TaxItemID { get; private set; }
        public int TaxID { get; private set; }
        public int ProductID { get; private set; }
        public clsUser LinkedByUserInfo { get; private set; }
        public DateTime LinkedAt { get; private set; }

        public clsTaxItem() { }

        public clsTaxItem(int taxID, int productID)
        {
            TaxID = taxID;
            ProductID = productID;
        }

        public static List<clsTaxItem> ConvertTaxItemsTableToList(DataTable taxTable)
        {
            List<clsTaxItem> taxItems = new List<clsTaxItem>();

            // To prevent NullReferenceException if the list is null.
            if (taxTable is null)
            {
                return taxItems;
            }

            foreach (DataRow discountItem in taxTable.Rows)
            {
                taxItems.Add(
                    new clsTaxItem
                    {
                        TaxItemID = (int)discountItem["TaxItemID"],
                        TaxID = (int)discountItem["TaxID"],
                        ProductID = (int)discountItem["ProductID"],
                        LinkedByUserInfo = clsUser.Find((int)discountItem["LinkedByUserID"]),
                        LinkedAt = (DateTime)discountItem["LinkedAt"]
                    }
                );
            }

            return taxItems;
        }

        public static DataTable ConvertTaxItemsListToTable(List<clsTaxItem> taxItemsList)
        {
            DataTable taxItemsTable = new DataTable();
            taxItemsTable.Columns.Add("ProductID");

            // To prevent NullReferenceException if the list is null.
            if (taxItemsList is null)
            {
                return taxItemsTable;
            }

            foreach (clsTaxItem taxItem in taxItemsList)
            {
                taxItemsTable.Rows.Add(
                    taxItem.ProductID
                    );
            }

            return taxItemsTable;
        }
    }
}
