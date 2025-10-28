using System;
using DataAccess.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsInventory
    {
        public static int GetInventoryQuantity(int warehouseID, int productID, int unitID)
        {
            return clsInventoryData.GetInventoryQuantity(warehouseID, productID, unitID);
        }
    }
}
