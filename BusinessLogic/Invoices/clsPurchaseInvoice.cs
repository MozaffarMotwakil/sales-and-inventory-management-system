using System;
using System.Collections.Generic;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseInvoice : clsInvoice
    {
        public clsSupplier Supplier { get; }

        public clsPurchaseInvoice(string invoiceNo, DateTime invoiceDate, enPaymentStatus invoiceStatus,
            List<clsInvoiceLine> lines, int supplierID, int warehouseID, enPaymentMethod? paymentMethod, decimal? paymentAmount) :
            base(null, invoiceNo, invoiceDate, enInvoiceType.Purchase, invoiceStatus, lines, warehouseID, paymentMethod, paymentAmount,
                null, null)
        {
            InvoiceNo = "PI-" + DateTime.Today.Year + '-' + invoiceNo;
            Supplier = clsSupplierService.CreateInstance().Find(supplierID);
        }

        internal clsPurchaseInvoice(clsInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceID, invoiceDTO.InvoiceNo, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enPaymentStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines, (enInvoiceType)invoiceDTO.InvoiceTypeID),
                invoiceDTO.WarehouseID, (enPaymentMethod?)invoiceDTO.PaymentMethodID, invoiceDTO.PaidAmount, invoiceDTO.CreatedByUserID,
                invoiceDTO.CreatedAt)
        {
            Supplier = clsSupplierService.CreateInstance().FindByPartyID(invoiceDTO.PartyID ?? -1);
        }

        public static DateTime GetFirstPurchaseInvoiceDate()
        {
            return clsInvoiceData.GetFirstPurchaseInvoiceDate();
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (Supplier == null)
            {
                validationResult.AddError("المورد", "يجب تعيين مورد للفاتورة");
            }

            if (Supplier != null && !Supplier.IsActive)
            {
                validationResult.AddError("المورد", $"المورد \"{GetPartyName()}\" غير نشط");
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
                InvoiceStatusID = (byte)this.PaymentStatus,
                PartyID = this.Supplier?.PartyInfo.PartyID,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte?)this.PaymentMethod,
                PaidAmount = this.PaidAmount,
                WarehouseID = this?.WarehouseInfo?.WarehouseID ?? -1,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public override string GetPartyName()
        {
            return Supplier == null ? "N/A" : Supplier.PartyInfo.PartyName;
        }

    }
}
