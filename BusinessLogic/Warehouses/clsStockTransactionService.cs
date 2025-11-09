using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using DataAccess.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsStockTransactionService : IEntityListManager<clsStockTransaction>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsStockTransactionService _Instance;
        private clsStockTransactionService() {}

        public static clsStockTransactionService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsStockTransactionService();
            }

            return _Instance;
        }

        public bool Delete(int id)
        {
            throw new InvalidOperationException("لا يمكن حذف سجل حركة مخزون");
        }

        public clsStockTransaction Find(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            return clsInventoryData.GetAllStockTransactions();
        }

        public static object[] GetAllStockTransactionTypeNames()
        {
            return clsInventoryData.GetAllStockTransactionTypeNames()
                .Rows
                .Cast<DataRow>()
                .Select(row => row[0])
                .ToArray();
        }

        public static DateTime GetFirstStockTransactionDate()
        {
            return clsInventoryData.GetFirstStockTransactionDate();
        }

    }
}
