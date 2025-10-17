using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using BusinessLogic.Parties;
using BusinessLogic.Users;
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

        public int? InvoiceID { get; }
        public string InvoiceNa { get; }
        public DateTime InvoiceDate { get; }
        public enInvoiceType InvoiceType { get; }
        public enInvoiceStatus InvoiceStatus { get; }
        public clsParty PartyInfo { get; }
        public decimal TotalSubTotal { get; }
        public decimal TotalDiscountAmount { get; }
        public decimal TotalTaxAmount { get; }
        public decimal GrandTotal { get; }
        public enPaymentMethod PaymentMethod { get; }
        public ReadOnlyCollection<clsInvoiceLine> Lines => _Lines.AsReadOnly();
        public decimal? CashPaidAmount { get; }
        public clsInvoice OriginalInvoiceInfo { get; }
        public clsUser CreatedByUserInfo { get; }
        public DateTime? CreateAt { get; }

        private List<clsInvoiceLine> _Lines { get; } = new List<clsInvoiceLine>();

        public clsInvoice(string invoiceNa, DateTime invoiceDate, enInvoiceType invoiceType,
            enInvoiceStatus invoiceStatus, clsParty party, List<clsInvoiceLine> lines,
            enPaymentMethod paymentMethod, decimal? cashPaidAmount, clsInvoice originalInvoice = null)
        {
            InvoiceNa = invoiceNa;
            InvoiceDate = invoiceDate;
            InvoiceType = invoiceType;
            InvoiceStatus = invoiceStatus;
            PartyInfo = party;
            _Lines = lines;
            TotalSubTotal = CalculateTotalSubTotal();
            TotalDiscountAmount = CalculateDiscountTotal();
            TotalTaxAmount = CalculateTaxTotal();
            GrandTotal = CalculateGrandTotal();
            PaymentMethod = paymentMethod;
            CashPaidAmount = cashPaidAmount;
            OriginalInvoiceInfo = originalInvoice;
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
            return _Lines.Sum(invokeLine => invokeLine.LineSubTotal);
        }

        public decimal CalculateTaxTotal()
        {
            return _Lines.Sum(invokeLine => invokeLine.Tax);
        }

        public decimal CalculateDiscountTotal()
        {
            return _Lines.Sum(invokeLine => invokeLine.Discount);
        }

        public decimal CalculateGrandTotal()
        {
            return _Lines.Sum(invokeLine => invokeLine.FinalLineTotal);
        }

        private clsInvoiceDTO MappingToDTO()
        {
            return new clsInvoiceDTO
            {
                InvoiceID = this.InvoiceID,
                InvoiceNa = this.InvoiceNa,
                InvoiceTypeID = (byte)this.InvoiceType,
                InvoiceStatusID = (byte)this.InvoiceStatus,
                PartyID = this.PartyInfo.PartyID.Value,
                Lines = clsInvoiceLine.CreateInvoiceLinesDataTable(this._Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (int)this.PaymentMethod,
                CashPaidAmount = this.CashPaidAmount,
                OriginalInvoiceID = this.OriginalInvoiceInfo?.InvoiceID,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
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

            if (PartyInfo == null || PartyInfo.PartyID == null)
            {
                validationResult.AddError("الطرف/العميل", "يجب تعيين طرف (عميل/مورد) صالح للفاتورة.");
            }

            if (InvoiceType < enInvoiceType.Purchase)
            {
                validationResult.AddError("نوع الفاتورة", "يجب اختيار نوع فاتورة صالح.");
            }

            if (InvoiceStatus < enInvoiceStatus.Paid)
            {
                validationResult.AddError("طريقة الدفع", "يجب اختيار حالة صالحة للفاتورة.");
            }

            if (PaymentMethod < enPaymentMethod.Cash)
            {
                validationResult.AddError("طريقة الدفع", "يجب اختيار طريقة دفع صالحة.");
            }

            if (InvoiceStatus == enInvoiceStatus.Paid || InvoiceStatus == enInvoiceStatus.PartiallyPaid)
            {
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

            decimal calculatedFinalTotal = TotalSubTotal - TotalDiscountAmount + TotalTaxAmount;

            if (GrandTotal != calculatedFinalTotal)
            {
                validationResult.AddError("الإجمالي الكلي", "الإجمالي الكلي لا يطابق مع المعادلة المالية: الإجمالي الفرعي - الخصم + الضريبة");
            }

            return validationResult;
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
                if (!clsInvoiceData.IssueInvoice(this.MappingToDTO()))
                {
                    validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                }

                return validationResult;
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                validationResult.AddError("قاعدة البيانات", ex.Message);
                return validationResult;
            }
            catch
            {
                validationResult.AddError("قاعدة البيانات", clsAppSettings.ErrorToConnectionFormDB);
                return validationResult;
            }
        }

    }
}
