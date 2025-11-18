using System;
using System.Data;
using System.Linq;
using BusinessLogic.Interfaces;
using DataAccess.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsStockTransactionService : IEntityListManager<clsStockTransaction>
    {
        public struct StockTransactionInfo
        {
            public int InTransactions { get; set; }
            public int OutTransactions { get; set; }
        }

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

        public static object[] GetStockTransactionTypeNames()
        {
            return clsInventoryData.GetAllStockTransactionTypeNames()
                .Rows
                .Cast<DataRow>()
                .Select(row => row[0])
                .ToArray();
        }

        public static object[] GetStockTransactionReasonNames()
        {
            return clsInventoryData.GetAllStockTransactionReasonNames()
                .Rows
                .Cast<DataRow>()
                .Select(row => row[0])
                .ToArray();
        }

        public static DateTime GetFirstStockTransactionDate()
        {
            return clsInventoryData.GetFirstStockTransactionDate();
        }

        public StockTransactionInfo GetStockTransactionInfo(DataTable dataSource)
        {
            StockTransactionInfo transactionInfo = new StockTransactionInfo();

            foreach (DataRow transaction in dataSource.Rows)
            {
                if ((int)transaction["TransactionTypeID"] == 1)
                {
                    transactionInfo.InTransactions += 1;
                }

                if ((int)transaction["TransactionTypeID"] == 2)
                {
                    transactionInfo.OutTransactions += 1;
                }
            }

            return transactionInfo; 
        }

        public StockTransactionInfo GetStockTransactionInfo(DataView dataSource)
        {
            return GetStockTransactionInfo(dataSource.ToTable());
        }

    }
}
