using System;
using System.Data;
using BusinessLogic.Interfaces;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsTransferOperationService : IEntityListManager<clsTransferOperation>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsTransferOperationService _Instance;

        private clsTransferOperationService() { }

        public static clsTransferOperationService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsTransferOperationService();
            }

            return _Instance;
        }

        public static DateTime GetFirstTransferOperationDate()
        {
            return clsWarehouseData.GetFirstTransferOperationDate();
        }

        public clsTransferOperation Find(int transferOperationID)
        {
            clsTransferOperationDTO transferOperationDTO = clsWarehouseData.FindStockTransferOperation(transferOperationID);
            return transferOperationDTO != null ? new clsTransferOperation(transferOperationDTO) : null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException("لا يمكن حذف سجل عملية نقل بضاعة");
        }

        public DataTable GetAll()
        {
            return clsWarehouseData.GetAllTransferOperations();
        }

    }
}
