using System;
using System.Collections.Generic;
using BusinessLogic.Parties;
using BusinessLogic.Suppliers;
using BusinessLogic.Validation;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseInvoice : clsInvoice
    {
        public clsPurchaseInvoice(string invoiceNa, DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            clsSupplier supplier, List<clsInvoiceLine> lines, enPaymentMethod paymentMethod, decimal? cashPaidAmount) :
            base(invoiceNa, invoiceDate, enInvoiceType.Purchase, invoiceStatus, supplier?.PartyInfo, lines, paymentMethod, cashPaidAmount)
        {

        }

        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (PartyInfo != null && !clsSupplierService.IsSupplierExistsByPartyID(PartyInfo.PartyID.Value))
            {
                validationResult.AddError("المورد", "لم يتم العثور على المورد.");
            }

            if (InvoiceType != enInvoiceType.Purchase)
            {
                validationResult.AddError("نوع الفاتورة", "الرجاء التأكد من أن نوع الفاتورة المحددة هو 'مشتريات'.");
            }

            if (InvoiceStatus != enInvoiceStatus.Unpaid && CashPaidAmount == null)
            {
                validationResult.AddError("الدفع النقدي", "إذا كانت الفاتورة مدفوعة، يجب أن يتم تسجيل مبلغ نقدي مدفوع.");
            }

            return validationResult;
        }

    }
}
