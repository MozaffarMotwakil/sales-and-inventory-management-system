using System;
using System.Data;

namespace DTOs.Warehouses
{
    public class clsTransferOperationDTO
    {
        public int? TransferOperationID { get; set; }
        public int SourceWarehouseID { get; set; }
        public int? DestinationWarehouseID { get; set; }
        public DataTable TransferedInventories { get; set; }
        public int ResponsibleEmployeeID { get; set; }
        public DateTime TransferOperationDateTime { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
