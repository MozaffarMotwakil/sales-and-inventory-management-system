using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogic.Validation;

namespace BusinessLogic.Warehouses
{
    public class clsTransferedInventory
    {
        public int? TransferedInventoryID { get; }
        public clsTransferOperation TransferOperationInfo { get; }
        public clsInventory SourceInventoryInfo { get; }
        public clsInventory DestinationInventoryInfo { get; }
        public int TransferedQuantity { get; }

        public clsTransferedInventory(int sourceInventoryID, int transferedQuantity)
        {
            TransferedInventoryID = null;
            TransferOperationInfo = null;
            SourceInventoryInfo = clsInventoryService.CreateInstance().Find(sourceInventoryID);
            DestinationInventoryInfo = null;
            TransferedQuantity = transferedQuantity;
        }

        internal clsTransferedInventory(int transferedInventoryID, int transferOperationID, int sourceInventoryID, int destinationInventoryID, int transferedQuantity)
        {
            TransferedInventoryID = transferedInventoryID;
            TransferOperationInfo = clsTransferOperation.Find(transferOperationID);
            SourceInventoryInfo = clsInventoryService.CreateInstance().Find(sourceInventoryID);
            DestinationInventoryInfo = clsInventoryService.CreateInstance().Find(destinationInventoryID);
            TransferedQuantity = transferedQuantity;
        }

        public static DataTable ConvertTransferedInventoriesListToTable(List<clsTransferedInventory> transferedInventories)
        {
            DataTable transferedInventoriesTable = new DataTable();

            transferedInventoriesTable.Columns.Add("SourceInventoryID", typeof(int));
            transferedInventoriesTable.Columns.Add("TransferedQuantity", typeof(int));

            foreach (clsTransferedInventory transferedInventoryList in transferedInventories)
            {
                transferedInventoriesTable.Rows.Add(
                    transferedInventoryList.SourceInventoryInfo.InventoryID,
                    transferedInventoryList.TransferedQuantity
                );
            }

            return transferedInventoriesTable;
        }

        public static List<clsTransferedInventory> ConvertTransferedInventoriesTableToList(DataTable transferedInventoriesTable)
        {
            List<clsTransferedInventory> transferedInventoriesList = new List<clsTransferedInventory>();

            if (transferedInventoriesTable != null)
            {
                foreach (DataRow row in transferedInventoriesTable.Rows)
                {
                    transferedInventoriesList.Add(
                        new clsTransferedInventory (
                            transferedInventoryID: Convert.ToInt32(row["TransferedInventoryID"]),
                            transferOperationID: Convert.ToInt32(row["TransferOperationID"]),
                            sourceInventoryID: Convert.ToInt32(row["SourceInventoryID"]),
                            destinationInventoryID: Convert.ToInt32(row["DestinationInventoryID"]),
                            transferedQuantity: Convert.ToInt32(row["TransferedQuantity"])
                            )
                    );
                }
            }

            return transferedInventoriesList;
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (SourceInventoryInfo == null)
            {
                validationResult.AddError("المخزون المصدر", "لم يتم العثور على المخزون");
            }

            if (TransferedQuantity <= 0)
            {
                validationResult.AddError("الكمية", "يجب أن تكون الكمية المراد نقلها أكبر من صفر");
            }

            if (SourceInventoryInfo != null && TransferedQuantity > SourceInventoryInfo.GetCurrentQuantity())
            {
                validationResult.AddError("الكمية", $"الكمية المراد نقلها من المخزون \"{SourceInventoryInfo.ProductInfo.ProductName} - {SourceInventoryInfo.UnitInfo.UnitName}\" أكبر من الكمية المتوفرة في المخزن");
            }

            return validationResult;
        }

    }
}
