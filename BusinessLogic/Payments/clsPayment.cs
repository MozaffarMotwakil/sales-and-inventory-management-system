using System;
using BusinessLogic.Invoices;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DTOs.Payments;

namespace BusinessLogic.Payments
{
    public class clsPayment
    {
        public int PaymentID { get; set; }
        public clsInvoice InvoiceInfo { get; set; }
        public decimal PaymentAmount { get; set; }
        public enPaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsPayment(clsInvoice invoiceInfo, decimal paymentAmount, enPaymentMethod paymentMethod, DateTime paymentDate)
        {
            InvoiceInfo = invoiceInfo;
            PaymentAmount = paymentAmount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }


        public clsPaymentDTO MappingToDTO()
        {
            return new clsPaymentDTO
            {
                PaymentID = this.PaymentID,
                InvoiceID = this.InvoiceInfo.InvoiceID.GetValueOrDefault(),
                PaymentAmount = this.PaymentAmount,
                PaymentDate = this.PaymentDate,
                PaymentMethodID = ((byte)this.PaymentMethod),
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (InvoiceInfo is null)
            {
                validationResult.AddError("الفاتورة", "لم يتم العثور على الفاتورة.");
            }

            if (InvoiceInfo != null && InvoiceInfo.PaymentStatus == enPaymentStatus.Paid)
            {
                validationResult.AddError("الفاتورة", "لا يمكن إصدار مدفوع لفاتورة مدفوعة بالكامل.");
            }

            if (PaymentDate > DateTime.Today)
            {
                validationResult.AddError("التاريخ", "لا يمكن أن يكون تاريخ المدفوع في المستقبل.");
            }

            if (!decimal.TryParse(PaymentAmount.ToString(), out decimal sellingPrice) || sellingPrice < 1)
            {
                validationResult.AddError("المبلغ المدفوع", "يجب أن يكون المبلغ المدفوع رقم أكبر من صفر");
            }
            else
            {
                if (InvoiceInfo != null && PaymentAmount > InvoiceInfo.RemainingAmount.GetValueOrDefault())
                {
                    validationResult.AddError("المبلغ المدفوع", $"المبلغ المدفوع \"{PaymentAmount}\" أكبر من المبلغ المتبقي \"{InvoiceInfo.RemainingAmount}\"");
                }
            }

            return validationResult;
        }

        public clsValidationResult IssuePayment()
        {
            return clsPaymentService.CreateInstance().IssuePayment(this);
        }

    }
}
