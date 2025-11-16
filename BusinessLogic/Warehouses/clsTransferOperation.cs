
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BusinessLogic.Employees;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Warehouses;
using DTOs.Warehouses;

namespace BusinessLogic.Warehouses
{
    public class clsTransferOperation
    {
        public int? TransferOperationID { get; }
        public clsWarehouse SourceWarehouseInfo { get; }
        public clsWarehouse DestianationWarehouseInfo { get; }
        public List<clsTransferedInventory> TransferedInventories { get; }
        public clsEmployee ResponsibleEmployeeInfo { get; }
        public DateTime TransferOperationDateTime { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreatedAt { get; }

        public clsTransferOperation(int sourceWarehouseID, int destianationWarehouseID, int responsibleEmployeeID,
            List<clsTransferedInventory> transferedInventories, DateTime transferOperationDateTime)
        {
            TransferOperationID = null;
            SourceWarehouseInfo = clsWarehouseService.CreateInstance().Find(sourceWarehouseID);
            DestianationWarehouseInfo = clsWarehouseService.CreateInstance().Find(destianationWarehouseID);
            TransferedInventories = transferedInventories;
            ResponsibleEmployeeInfo = clsEmployeeService.Find(responsibleEmployeeID);
            TransferOperationDateTime = transferOperationDateTime;
            CreatedByUserInfo = clsAppSettings.CurrentUser;
        }

        internal clsTransferOperation(clsTransferOperationDTO transferOperationDTO)
        {
            TransferOperationID = transferOperationDTO.TransferOperationID;
            SourceWarehouseInfo = clsWarehouseService.CreateInstance().Find(transferOperationDTO.SourceWarehouseID);
            DestianationWarehouseInfo = clsWarehouseService.CreateInstance().Find(transferOperationDTO.DestinationWarehouseID);
            TransferedInventories = clsTransferedInventory.ConvertTransferedInventoriesTableToList(transferOperationDTO.TransferedInventories);
            ResponsibleEmployeeInfo = clsEmployeeService.Find(transferOperationDTO.ResponsibleEmployeeID);
            TransferOperationDateTime = transferOperationDTO.TransferOperationDateTime;
            CreatedByUserInfo = clsUser.Find(transferOperationDTO.CreatedByUserID);
        }

        public static clsTransferOperation Find(int transferOperationID)
        {
            clsTransferOperationDTO transferOperationDTO = clsWarehouseData.FindStockTransferOperation(transferOperationID);
            return transferOperationDTO == null ? null : new clsTransferOperation(transferOperationDTO);
        }

        private clsTransferOperationDTO MappingToDTO()
        {
            return new clsTransferOperationDTO
            {
                TransferOperationID = this.TransferOperationID,
                SourceWarehouseID = this.SourceWarehouseInfo.WarehouseID ?? -1,
                DestinationWarehouseID = this.DestianationWarehouseInfo.WarehouseID ?? -1,
                TransferedInventories = clsTransferedInventory.ConvertTransferedInventoriesListToTable(this.TransferedInventories),
                ResponsibleEmployeeID = this.ResponsibleEmployeeInfo.EmployeeID,
                TransferOperationDateTime = this.TransferOperationDateTime,
                CreatedByUserID = this.CreatedByUserInfo.UserID,
                CreatedAt = this.CreatedAt,
            };
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (SourceWarehouseInfo == null)
            {
                validationResult.AddError("المخزن المصدر", "لم يتم العثور على المخزن");
            }

            if (SourceWarehouseInfo == null)
            {
                validationResult.AddError("المخزن الوجهة", "لم يتم العثور على المخزن");
            }

            if (TransferedInventories == null || TransferedInventories.Count == 0)
            {
                validationResult.AddError("المخزونات المراد نقلها", "يجب أن يكون هناك مخزون واحد على الأقل يراد نقله لتتم عملية النقل");
            }
            else
            {
                foreach (clsTransferedInventory transferedInventory in TransferedInventories)
                {
                    clsValidationResult inventoriesValidation = transferedInventory.Validated();

                    if (!inventoriesValidation.IsValid)
                    {
                        foreach (clsValidationResult.clsValidationError error in inventoriesValidation.Errors)
                        {
                            validationResult.AddError(error.FieldName, error.ErrorMessage);
                        }
                    }
                }
            }

            if (ResponsibleEmployeeInfo == null)
            {
                validationResult.AddError("الموظف المسؤول", "لم يتم العثور على الموظف المسؤول");
            }

            if (TransferOperationDateTime > DateTime.Now)
            {
                validationResult.AddError("تاريخ/وقت عملية النقل", "لا يمكن أن تكون عملية النقل في المستقبل");
            }

            return validationResult;
        }

        public clsValidationResult PerformTransferOperation()
        {
            clsValidationResult validationResult = this.Validated();

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            try
            {
                if (!clsWarehouseData.PerformStockTransferOperation(this.MappingToDTO()))
                {
                    validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                }
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                throw new InvalidOperationException(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception(clsAppSettings.ErrorToConnectionFormDB, ex);
            }

            return validationResult;
        }

    }
}
