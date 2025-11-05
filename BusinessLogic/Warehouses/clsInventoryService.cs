using System;
using System.Data;
using BusinessLogic.Interfaces;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsInventoryService : IEntityListManager<clsInventory>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsInventoryService _Instance;

        private clsInventoryService() { }

        public static clsInventoryService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsInventoryService();
            }

            return _Instance;
        }

        private void OnInventorySaved(int inventoryID, string productName, string unitName)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(inventoryID, productName + " - " + unitName, enMode.Update));
        }

        public static int GetInventoryQuantity(int warehouseID, int productID, int unitID)
        {
            return clsInventoryData.GetInventoryQuantity(warehouseID, productID, unitID);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException("لا يمكن حذف مخزون");
        }

        public clsInventory Find(int inventoryID)
        {
            if (inventoryID < 1)
            {
                return null;
            }

            clsInventoryDTO inventoryDTO = clsInventoryData.FindInventoryByID(inventoryID);
            return inventoryDTO is null ? null : new clsInventory(inventoryDTO);
        }

        public DataTable GetAll()
        {
            return clsInventoryData.GetAllInventories();
        }

        public bool UpdateReorderQuantity(clsInventory inventory,  int newReorderQuantity)
        {
            if (inventory == null)
            {
                return false;
            }

            if (clsInventoryData.UpdateReorderQuantity(inventory.InventoryID, newReorderQuantity))
            {
                OnInventorySaved(inventory.InventoryID, inventory.ProductInfo.ProductName, inventory.UnitInfo.UnitName);
                return true;
            }

            return false;
        }

    }
}
