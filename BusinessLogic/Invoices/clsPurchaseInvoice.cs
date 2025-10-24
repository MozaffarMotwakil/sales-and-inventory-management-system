using System;
using System.Collections.Generic;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseInvoice : clsInvoice
    {
        public clsSupplier Supplier { get; }

        public clsPurchaseInvoice(string invoiceNa, DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, enPaymentMethod? paymentMethod, decimal? cashPaidAmount, clsSupplier supplier = null) :
            base(invoiceNa, invoiceDate, enInvoiceType.Purchase, invoiceStatus, lines, paymentMethod, cashPaidAmount)
        {
            Supplier = supplier;
        }

        internal clsPurchaseInvoice(clsPurchaseInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceNa, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enInvoiceStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines), 
                (enPaymentMethod)invoiceDTO.PaymentMethodID, invoiceDTO.CashPaidAmount)
        {
            Supplier = clsSupplierService.CreateInstance().Find(invoiceDTO.SupplierID ?? -1);
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
                CashPaidAmount = this.CashPaidAmount,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

    }
}
