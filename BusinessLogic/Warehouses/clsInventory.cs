using BusinessLogic.Products;
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

        internal clsInventory(clsInventoryDTO inventoryDTO)
        {
            InventoryID = inventoryDTO.InventoryID;
            WarehouseInfo = clsWarehouseService.CreateInstance().Find(inventoryDTO.WarehouseID);
            ProductInfo = clsProductService.CreateInstance().Find(inventoryDTO.ProductID);
            UnitInfo = clsUnit.Find(inventoryDTO.UnitID);
            ReorderQuantity = inventoryDTO.ReorderQuantity;
        }

    }
}