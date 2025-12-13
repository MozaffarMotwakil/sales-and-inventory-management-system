using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogic.Users;

namespace BusinessLogic.Products
{
    public class clsDiscountItem
    {
        public int DiscountItemID { get; private set; }
        public int DiscountID { get; private set; }
        public int ProductID { get; private set; }
        public int UnitID { get; private set; }
        public clsUser LinkedByUserInfo { get; private set; }
        public DateTime LinkedAt { get; private set; }

        public clsDiscountItem() { }

        public clsDiscountItem(int discountID, int productID, int unitID)
        {
            DiscountItemID = discountID;
            ProductID = productID;
            UnitID = unitID;
        }

        public static List<clsDiscountItem> ConvertDiscountItemsTableToList(DataTable discountTable)
        {
            List<clsDiscountItem> discountItems = new List<clsDiscountItem>();

            // To prevent NullReferenceException if the list is null.
            if (discountTable is null)
            {
                return discountItems;
            }

            foreach (DataRow discountItem in discountTable.Rows)
            {
                discountItems.Add(
                    new clsDiscountItem
                    {
                        DiscountItemID = (int)discountItem["DiscountItemID"],
                        DiscountID = (int)discountItem["DiscountID"],
                        ProductID = (int)discountItem["ProductID"],
                        UnitID = (int)discountItem["UnitID"],
                        LinkedByUserInfo = clsUser.Find((int)discountItem["LinkedByUserID"]),
                        LinkedAt = (DateTime)discountItem["LinkedAt"]
                    }
                );
            }

            return discountItems;
        }

        public static DataTable ConvertDiscountItemsListToTable(List<clsDiscountItem> discountItemsList)
        {
            DataTable discountItemsTable = new DataTable();
            discountItemsTable.Columns.Add("ProductID");
            discountItemsTable.Columns.Add("UnitID");

            // To prevent NullReferenceException if the list is null.
            if (discountItemsList is null)
            {
                return discountItemsTable;
            }

            foreach (clsDiscountItem discountItem in discountItemsList)
            {
                discountItemsTable.Rows.Add(
                    discountItem.ProductID,
                    discountItem.UnitID
                    );
            }

            return discountItemsTable;
        }

    }
}
