using System.Data;
using BusinessLogic.Products;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsInventory
    {
        public int InventoryID { get; set; }
        public clsWarehouse WarehouseInfo { get; set; }
        public clsProduct ProductInfo { get; set; }
        public clsUnit UnitInfo { get; set; }
        public int ReorderQuantity { get; set; }
        public float AveragePurchasePrice => clsInventoryData.GetAveragePurchasePrice(this.ProductInfo?.ProductID ?? -1, UnitInfo?.UnitID ?? -1);
        public float SellingPrice => clsInventoryData.GetSellingPrice(this.ProductInfo?.ProductID ?? -1, UnitInfo?.UnitID ?? -1);

        internal clsInventory(clsInventoryDTO inventoryDTO)
        {
            InventoryID = inventoryDTO.InventoryID;
            WarehouseInfo = clsWarehouseService.CreateInstance().Find(inventoryDTO.WarehouseID);
            ProductInfo = clsProductService.CreateInstance().Find(inventoryDTO.ProductID);
            UnitInfo = clsUnit.Find(inventoryDTO.UnitID);
            ReorderQuantity = inventoryDTO.ReorderQuantity;
        }

        public bool UpdateReorderQuantity(int newReorderQuantity)
        {
            if (clsInventoryData.UpdateReorderQuantity(this.InventoryID, newReorderQuantity))
            {
                clsInventoryService.CreateInstance().OnInventorySaved(this.InventoryID, this.ProductInfo.ProductName, this.UnitInfo.UnitName);
                return true;
            }

            return false;
        }

        public int GetCurrentQuantity()
        {
            return clsInventoryData.GetInventoryQuantity(
                this.WarehouseInfo.WarehouseID ?? -1, this.ProductInfo.ProductID ?? -1, this.UnitInfo.UnitID
                );
        }

        public string GetStatus()
        {
            return clsInventoryData.GetInventoryStatus(this.InventoryID);
        }

        public DataTable GetStockTransactions()
        {
            return clsInventoryData.GetAllStockTransactionsByInventoryID(this.InventoryID);
        }

    }
}