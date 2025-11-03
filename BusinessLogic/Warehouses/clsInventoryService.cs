using System;
using System.Data;
using BusinessLogic.Interfaces;
using DataAccess.Warehouses;

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

        public static int GetInventoryQuantity(int warehouseID, int productID, int unitID)
        {
            return clsInventoryData.GetInventoryQuantity(warehouseID, productID, unitID);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException("لا يمكن حذف مخزون");
        }

        public clsInventory Find(int id)
        {
            throw new NotImplementedException("لم يتم تطبيق ميزة البحث عن مخزون بعد");
        }

        public DataTable GetAll()
        {
            return clsInventoryData.GetAllInventories();
        }

    }
}
