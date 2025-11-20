using System;

namespace DTOs.Warehouses
{
    public class clsStockTransactionDTO
    {
        public int TransactionID { get; set; }
        public int InventoryID { get; set; }
        public int OriginalQuantity { get; set; }
        public int QuantityChange { get; set; }
        public int TransactionTypeID { get; set; }
        public int TransactionReasonID { get; set; }
        public int? SourceInvoiceID { get; set; }
        public int? TransferOperationID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
