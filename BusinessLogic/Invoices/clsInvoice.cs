using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BusinessLogic.Users;
using BusinessLogic.Utilities;
using BusinessLogic.Validation;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public abstract class clsInvoice
    {
        public enum enInvoiceType
        {
            Purchase = 1,
            PurchaseReturn,
            Sales,
            SalesReturn
        }

        public enum enInvoiceStatus
        {
            Paid = 1,
            PartiallyPaid,
            Unpaid
        }

        public enum enPaymentMethod
        {
            Cash = 1,
            BankTransfer
        }

        protected int? InvoiceID { get; }
        protected string InvoiceNa { get; }
        protected DateTime InvoiceDate { get; }
        protected enInvoiceType InvoiceType { get; }
        protected enInvoiceStatus InvoiceStatus { get; }
        protected List<clsInvoiceLine> Lines { get; } = new List<clsInvoiceLine>();
        protected decimal TotalSubTotal => CalculateTotalSubTotal();
        protected decimal TotalDiscountAmount => CalculateDiscountTotal();  
        protected decimal TotalTaxAmount => CalculateTaxTotal();
        public decimal GrandTotal => CalculateGrandTotal();
        protected enPaymentMethod? PaymentMethod { get; }
        protected decimal? CashPaidAmount { get; }
        protected clsUser CreatedByUserInfo { get; }
        protected DateTime? CreateAt { get; }

        protected clsInvoice(string invoiceNa, DateTime invoiceDate, enInvoiceType invoiceType,
            enInvoiceStatus invoiceStatus, List<clsInvoiceLine> lines,
            enPaymentMethod? paymentMethod, decimal? cashPaidAmount)
        {
            InvoiceNa = invoiceNa;
            InvoiceDate = invoiceDate;
            InvoiceType = invoiceType;
            InvoiceStatus = invoiceStatus;
            Lines = lines;
            PaymentMethod = paymentMethod;
            CashPaidAmount = cashPaidAmount;
        }

        public bool IsInvoiceExists(int invoiceID)
        {
            return clsInvoiceData.IsInvoiceExists(invoiceID);
        }

        public bool IsInvoiceExists(string invoiceNa)
        {
            return clsInvoiceData.IsInvoiceExists(invoiceNa);
        }

        public decimal CalculateTotalSubTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.LineSubTotal);
        }

        public decimal CalculateTaxTotal()
        {
            return Lines.Sum(invokeLine => (invokeLine.LineSubTotal - invokeLine.Discount) * (invokeLine.TaxRate / 100));
        }

        public decimal CalculateDiscountTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.Discount);
        }

        public decimal CalculateGrandTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.FinalLineTotal);
        }

        public virtual clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (string.IsNullOrWhiteSpace(InvoiceNa))
            {
                validationResult.AddError("رقم الفاتورة", "لا يمكن أن يكون الرقم المرجعي للفاتورة فارغًا.");
            }

            if (IsInvoiceExists(InvoiceNa))
            {
                validationResult.AddError("رقم الفاتورة", "توجد فاتورة بنفس الرقم, لا يمكن أن يتكرر رقم الفاتورة.");
            }

            if (InvoiceDate > DateTime.Today)
            {
                validationResult.AddError("التاريخ", "لا يمكن أن يكون تاريخ الفاتورة في المستقبل.");
            }

            if (!Enum.IsDefined(typeof(enInvoiceType), InvoiceType))
            {
                validationResult.AddError("نوع الفاتورة", "يجب اختيار نوع فاتورة صالح.");
            }

            if (!Enum.IsDefined(typeof(enInvoiceStatus), InvoiceStatus))
            {
                validationResult.AddError("حالة الفاتورة", "يجب اختيار حالة صالحة للفاتورة.");
            }

            if (InvoiceStatus == enInvoiceStatus.Paid || InvoiceStatus == enInvoiceStatus.PartiallyPaid)
            {
                if (!Enum.IsDefined(typeof(enPaymentMethod), PaymentMethod))
                {
                    validationResult.AddError("طريقة الدفع", "يجب اختيار طريقة دفع صالحة.");
                }

                if (CashPaidAmount == null || CashPaidAmount < 0)
                {
                    validationResult.AddError("المبلغ النقدي المدفوع", "يجب تحديد مبلغ مدفوع موجب.");
                }

                if (InvoiceStatus == enInvoiceStatus.Paid && CashPaidAmount < GrandTotal)
                {
                    validationResult.AddError("حالة الدفع", "حالة الفاتورة 'مدفوعة بالكامل' تتطلب دفع المبلغ الكلي.");
                }

                if (CashPaidAmount > GrandTotal)
                {
                    validationResult.AddError("المبلغ النقدي المدفوع", "المبلغ المدفوع لا يمكن أن يتجاوز الإجمالي الكلي للفاتورة.");
                }
            }

            if (Lines == null || Lines.Count == 0)
            {
                validationResult.AddError("السطور", "يجب أن تحتوي الفاتورة على سطر واحد على الأقل.");
                return validationResult;
            }

            for (int i = 0; i < Lines.Count; i++)
            {
                clsInvoiceLine line = Lines[i];

                clsValidationResult lineValidation = line.Validated();

                if (!lineValidation.IsValid)
                {
                    foreach (var error in lineValidation.Errors)
                    {
                        validationResult.AddError($"السطر {i + 1}: {error.FieldName}", error.ErrorMessage);
                    }
                }
            }

            if (TotalSubTotal != Lines.Sum(line => line.LineSubTotal))
            {
                validationResult.AddError("الإجمالي الفرعي", "الإجمالي الفرعي للفاتورة غير متطابق مع مجموع السطور.");
            }

            if (GrandTotal != Lines.Sum(line => line.FinalLineTotal))
            {
                validationResult.AddError("الإجمالي الكلي", "الإجمالي الكلي للفاتورة غير متطابق مع مجموع السطور النهائي.");
            }

            decimal calculatedFinalTotal = (TotalSubTotal - TotalDiscountAmount) + (TotalTaxAmount);

            if (GrandTotal != calculatedFinalTotal)
            {
                validationResult.AddError("الإجمالي الكلي", "الإجمالي الكلي لا يطابق مع المعادلة المالية: الإجمالي الفرعي - الخصم + الضريبة");
            }

            return validationResult;
        }

        protected virtual clsInvoiceDTO MappingToDTO() 
        {
            throw new NotImplementedException(""); 
        }

        public clsValidationResult Issue()
        {
            clsValidationResult validationResult = this.Validated();
                
            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            try
            {
                clsInvoiceDTO dto = MappingToDTO();

                if (!clsInvoiceData.IssueInvoice(dto))
                {
                    validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                }
                else
                {
                    clsPurchaseInvoiceService.CreateInstance().OnPurchaseInvoiceIssued(dto.InvoiceID.Value, dto.InvoiceNa, enMode.Add);
                }

                return validationResult;
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                validationResult.AddError("قاعدة البيانات", ex.Message);
                return validationResult;
            }
            catch (Exception ex)
            {
                validationResult.AddError("قاعدة البيانات", clsAppSettings.ErrorToConnectionFormDB);
                clsEventLogger.LogErrorToWindowsEventLog(clsAppSettings.ErrorToConnectionFormDB, ex);
                return validationResult;
            }
        }

    }
}
