using System;
using BusinessLogic.Invoices;
using BusinessLogic.Users;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsStockTransaction
    {
        public enum enTransactionType
        {
            IN = 1,
            OUT
        }

        public enum enTransactionReason
        {
            Purchase = 1,
            PurchaseReturn,
            Sales,
            SalesReturn,
            TransferOperation,
            ConvertingInventoryUnit
        }

        public int TransactionID { get; }
        public clsInventory InventoryInfo { get; }
        public int OriginalQuantity { get; }
        public int QuantityChange { get; }
        public enTransactionType TransactionType { get; }
        public enTransactionReason TransactionReason { get; }
        public clsInvoice SourceInvoiceInfo { get; }
        public clsTransferOperation TransferOperationInfo { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime CreatedAt { get; }

        internal clsStockTransaction(clsStockTransactionDTO stockTransactionDTO)
        {
            TransactionID = stockTransactionDTO.TransactionID;
            InventoryInfo = clsInventoryService.CreateInstance().Find(stockTransactionDTO.InventoryID);
            OriginalQuantity = stockTransactionDTO.OriginalQuantity;
            QuantityChange = stockTransactionDTO.QuantityChange;
            TransactionType = (enTransactionType)stockTransactionDTO.TransactionTypeID;
            TransactionReason = (enTransactionReason)stockTransactionDTO.TransactionReasonID;
            SourceInvoiceInfo = clsInvoiceService.CreateInstance().Find(stockTransactionDTO.SourceInvoiceID ?? -1);
            TransferOperationInfo = clsTransferOperationService.CreateInstance().Find(stockTransactionDTO.TransferOperationID ?? -1);
            CreatedByUserInfo = clsUser.Find(stockTransactionDTO.CreatedByUserID);
            CreatedAt = stockTransactionDTO.CreatedAt;
        }

    }
}
