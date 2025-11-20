using System;
using System.Collections.Generic;
using System.Data;
using BusinessLogic.Validation;

namespace BusinessLogic.Warehouses
{
    public class clsTransferedInventory
    {
        public int? TransferedInventoryID { get; }
        public clsInventory SourceInventoryInfo { get; }
        public clsInventory DestinationInventoryInfo { get; }
        public int PrevioustSourceInventoryQuantity { get; }
        public int NextSourceInventoryQuantity =>
            PrevioustSourceInventoryQuantity - TransferedQuantity;
        public int PreviousDestinationInventoryQuantity { get; }
        public int NextDestinationInventoryQuantity => 
            PreviousDestinationInventoryQuantity + TransferedQuantity;
        public int TransferedQuantity { get; }
        public float InventoryAveragePurchasePrice { get; }
        public float TransferedInventoryValue =>
            InventoryAveragePurchasePrice * TransferedQuantity;

        public clsTransferedInventory(int sourceInventoryID, int transferedQuantity, float inventoryAveragePurchasePrice)
        {
            TransferedInventoryID = null;
            SourceInventoryInfo = clsInventoryService.CreateInstance().Find(sourceInventoryID);
            DestinationInventoryInfo = null;
            TransferedQuantity = transferedQuantity;
            InventoryAveragePurchasePrice = inventoryAveragePurchasePrice;
        }

        internal clsTransferedInventory(int transferedInventoryID, int sourceInventoryID, int destinationInventoryID,
            int previousSourceInventoryQuantity, int previousDestinationInventoryQuantity, int transferedQuantity,
            float inventoryAveragePurchasePrice)
        {
            TransferedInventoryID = transferedInventoryID;
            SourceInventoryInfo = clsInventoryService.CreateInstance().Find(sourceInventoryID);
            DestinationInventoryInfo = clsInventoryService.CreateInstance().Find(destinationInventoryID);
            TransferedQuantity = transferedQuantity;
            PrevioustSourceInventoryQuantity = previousSourceInventoryQuantity;
            PreviousDestinationInventoryQuantity = previousDestinationInventoryQuantity;
            InventoryAveragePurchasePrice = inventoryAveragePurchasePrice;
        }

        public static DataTable ConvertTransferedInventoriesListToTable(List<clsTransferedInventory> transferedInventories)
        {
            DataTable transferedInventoriesTable = new DataTable();

            transferedInventoriesTable.Columns.Add("SourceInventoryID", typeof(int));
            transferedInventoriesTable.Columns.Add("TransferedQuantity", typeof(int));
            transferedInventoriesTable.Columns.Add("InventoryAveragePurchasePrice", typeof(float));

            foreach (clsTransferedInventory transferedInventoryList in transferedInventories)
            {
                transferedInventoriesTable.Rows.Add(
                    transferedInventoryList.SourceInventoryInfo.InventoryID,
                    transferedInventoryList.TransferedQuantity,
                    transferedInventoryList.InventoryAveragePurchasePrice
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
                            sourceInventoryID: Convert.ToInt32(row["SourceInventoryID"]),
                            destinationInventoryID: Convert.ToInt32(row["DestinationInventoryID"]),
                            previousSourceInventoryQuantity: Convert.ToInt32(row["PreviousSourceInventoryQuantity"]),
                            previousDestinationInventoryQuantity: Convert.ToInt32(row["PreviousDestinationInventoryQuantity"]),
                            transferedQuantity: Convert.ToInt32(row["TransferedQuantity"]),
                            inventoryAveragePurchasePrice: Convert.ToSingle(row["InventoryAveragePurchasePrice"])
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
