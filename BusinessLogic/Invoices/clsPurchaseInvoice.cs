using System;
using System.Collections.Generic;
using BusinessLogic.Suppliers;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseInvoice : clsInvoice
    {
        public clsSupplier Supplier { get; }

        public clsPurchaseInvoice(string invoiceNa, DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, enPaymentMethod? paymentMethod, decimal? cashPaidAmount, int? supplierID,
            int warehouseID) :
            base(invoiceNa, invoiceDate, enInvoiceType.Purchase, invoiceStatus, lines,
                clsWarehouseService.CreateInstance().Find(warehouseID), paymentMethod, cashPaidAmount)
        {
            Supplier = clsSupplierService.CreateInstance().Find(supplierID ?? -1);
        }

        internal clsPurchaseInvoice(clsPurchaseInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceNa, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enInvoiceStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines),
                clsWarehouseService.CreateInstance().Find(invoiceDTO.WarehouseID), (enPaymentMethod)invoiceDTO.PaymentMethodID, invoiceDTO.PaymentAmount)
        {
            Supplier = clsSupplierService.CreateInstance().FindByPartyID(invoiceDTO.PartyID ?? -1);
            CreatedByUserInfo = clsUser.Find(invoiceDTO.CreatedByUserID.Value);
            CreateAt = invoiceDTO.CreatedAt;
        }


        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (Supplier != null && !clsSupplierService.IsSupplierExistsByPartyID(Supplier.PartyInfo.PartyID.Value))
            {
                validationResult.AddError("المورد", "لم يتم العثور على المورد.");
            }

            if (InvoiceType != enInvoiceType.Purchase)
            {
                validationResult.AddError("نوع الفاتورة", "الرجاء التأكد من أن نوع الفاتورة المحددة هو 'مشتريات'.");
            }

            return validationResult;
        }

        protected override clsInvoiceDTO MappingToDTO()
        {
            return new clsPurchaseInvoiceDTO
            {
                InvoiceID = this.InvoiceID,
                InvoiceNa = this.InvoiceNa,
                InvoiceDate = this.InvoiceDate,
                InvoiceTypeID = (byte)this.InvoiceType,
                InvoiceStatusID = (byte)this.InvoiceStatus,
                PartyID = this.Supplier?.PartyInfo.PartyID,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte)this.PaymentMethod,
                PaymentAmount = this.PaymentAmount,
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
