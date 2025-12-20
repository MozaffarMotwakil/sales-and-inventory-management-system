using System;
using System.Collections.Generic;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsSaleInvoice : clsInvoice
    {
        public clsSaleInvoice(DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, int? customerID, int warehouseID, enPaymentMethod? paymentMethod, decimal? paymentAmount) :
            base(null, "SI-" + DateTime.Today.Year + '-' + (GetSaleInvoicesCount() + 1), invoiceDate, enInvoiceType.Sales, invoiceStatus, lines, warehouseID, paymentMethod, paymentAmount,
                null, null)
        {

        }

        internal clsSaleInvoice(clsInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceID, invoiceDTO.InvoiceNo, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enInvoiceStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines, (enInvoiceType)invoiceDTO.InvoiceTypeID),
                invoiceDTO.WarehouseID, (enPaymentMethod?)invoiceDTO.PaymentMethodID, invoiceDTO.PaymentAmount, invoiceDTO.CreatedByUserID,
                invoiceDTO.CreatedAt)
        {

        }

        public static int GetSaleInvoicesCount()
        {
            return clsInvoiceData.GetSaleInvoicesCount();
        }

        public static DateTime GetFirstSaleInvoiceDate()
        {
            return clsInvoiceData.GetFirstSaleInvoiceDate();
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (Lines != null)
            {
                foreach (clsInvoiceLine line in Lines)
                {
                    int inventoryQuantity = clsInventoryService.GetInventoryQuantity(this.WarehouseInfo.WarehouseID ?? -1, line.ProductID.GetValueOrDefault(), line.UnitID.GetValueOrDefault());

                    if (line.Quantity > inventoryQuantity)
                    {
                        validationResult.AddError(line.ProductInfo.ProductName + "-" + line.UnitInfo.UnitName,
                            $"كمية البضاعة التي يراد بيعها أكبر من كمية المخزون الحالي, الكمية المتوفرة حاليا هي {inventoryQuantity} {line.UnitInfo.UnitName} فقط");
                    }
                }
            }

            return validationResult;
        }

        protected override clsInvoiceDTO MappingToDTO()
        {
            return new clsInvoiceDTO
            {
                InvoiceID = this.InvoiceID,
                InvoiceNo = this.InvoiceNo,
                InvoiceDate = this.InvoiceDate,
                InvoiceTypeID = (byte)this.InvoiceType,
                InvoiceStatusID = (byte)this.InvoiceStatus,
                PartyID = null,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte?)this.PaymentMethod,
                PaymentAmount = this.PaymentAmount,
                WarehouseID = this?.WarehouseInfo?.WarehouseID ?? -1,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public override string GetPartyName()
        {
            return "N/A";
        }

    }
}
