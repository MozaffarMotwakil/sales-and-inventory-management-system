using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using BusinessLogic.Users;
using BusinessLogic.Utilities;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
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

    public abstract class clsInvoice
    {
        public int? InvoiceID { get; }
        public string InvoiceNo { get; protected set; }
        public DateTime InvoiceDate { get; }
        public enInvoiceType InvoiceType { get; }
        public enInvoiceStatus InvoiceStatus { get; }
        public List<clsInvoiceLine> Lines { get; } = new List<clsInvoiceLine>();
        public decimal TotalSubTotal => CalculateTotalSubTotal();
        public decimal TotalDiscountAmount => CalculateDiscountTotal();
        public decimal TotalTaxAmount => CalculateTaxTotal();
        public decimal GrandTotal => CalculateGrandTotal();
        public enPaymentMethod? PaymentMethod { get; }
        public decimal? PaymentAmount { get; }
        public clsWarehouse WarehouseInfo { get; }
        public clsUser CreatedByUserInfo { get; protected set; }
        public DateTime? CreateAt { get; protected set; }

        protected clsInvoice(int? invoiceID, string invoiceNo, DateTime invoiceDate, enInvoiceType invoiceType, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, int warehouseID, enPaymentMethod? paymentMethod, decimal? cashPaidAmount)
        {
            InvoiceID = invoiceID;
            InvoiceNo = invoiceNo;
            InvoiceDate = invoiceDate;
            InvoiceType = invoiceType;
            InvoiceStatus = invoiceStatus;
            Lines = lines;
            WarehouseInfo = clsWarehouseService.CreateInstance().Find(warehouseID);
            PaymentMethod = paymentMethod;
            PaymentAmount = cashPaidAmount;
        }
        
        private decimal CalculateTotalSubTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.LineSubTotal);
        }

        private decimal CalculateTaxTotal()
        {
            return Lines.Sum(invokeLine => (invokeLine.LineSubTotal - (invokeLine.LineSubTotal * invokeLine.DiscountPercentage / 100)) * (invokeLine.TaxRate / 100));
        }

        private decimal CalculateDiscountTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.LineSubTotal * invokeLine.DiscountPercentage / 100);
        }

        private decimal CalculateGrandTotal()
        {
            return Lines.Sum(invokeLine => invokeLine.LineGrandTotal);
        }

        public abstract string GetPartyName();
        
        public string GetInvoiceTypeName()
        {
            switch (this.InvoiceType)
            {
                case enInvoiceType.Purchase:
                    return "مشتريات";
                case enInvoiceType.PurchaseReturn:
                    return "مرتجعات مشتريات";
                case enInvoiceType.Sales:
                    return "مبيعات";
                case enInvoiceType.SalesReturn:
                    return "مرتجعات مبيعات";
                default:
                    throw new InvalidEnumArgumentException("لم يتم التعرف على نوع الفاتورة");
            }
        }

        public string GetInvoiceStatusName()
        {
            switch (this.InvoiceStatus)
            {
                case enInvoiceStatus.Paid:
                    return "مدفوعة بالكامل";
                case enInvoiceStatus.PartiallyPaid:
                    return "مدفوعة جزئيا";
                case enInvoiceStatus.Unpaid:
                    return "غير مدفوعة";
                default:
                    throw new InvalidEnumArgumentException("لم يتم التعرف على حالة الفاتورة");
            }
        }

        public string GetPaymentMethodName()
        {
            switch (this.PaymentMethod)
            {
                case enPaymentMethod.Cash:
                    return "كاش";
                case enPaymentMethod.BankTransfer:
                    return "تحويل بنكي";
                default:
                    return "N/A";

            }
        }

        public virtual clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();

            if (string.IsNullOrWhiteSpace(InvoiceNo))
            {
                validationResult.AddError("رقم الفاتورة", "لا يمكن أن يكون رقم الفاتورة فارغًا.");
            }

            if (clsInvoiceService.IsInvoiceExists(InvoiceNo))
            {
                validationResult.AddError("رقم الفاتورة", "توجد فاتورة بنفس الرقم, لا يمكن أن يتكرر رقم الفاتورة.");
            }

            if (InvoiceDate > DateTime.Today)
            {
                validationResult.AddError("التاريخ", "لا يمكن أن يكون تاريخ الفاتورة في المستقبل.");
            }

            if (WarehouseInfo == null || !WarehouseInfo.IsActive)
            {
                validationResult.AddError("المخزن", "يجب تعيين مخزن صالح للفاتورة");
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

                if (PaymentAmount == null || PaymentAmount < 0)
                {
                    validationResult.AddError("المبلغ النقدي المدفوع", "يجب تحديد مبلغ مدفوع موجب.");
                }

                if (InvoiceStatus == enInvoiceStatus.Paid && PaymentAmount < GrandTotal)
                {
                    validationResult.AddError("حالة الدفع", "حالة الفاتورة 'مدفوعة بالكامل' تتطلب دفع المبلغ الكلي.");
                }

                if (PaymentAmount > GrandTotal)
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

            if (GrandTotal != Lines.Sum(line => line.LineGrandTotal))
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

        protected abstract clsInvoiceDTO MappingToDTO();

        public clsValidationResult Issue()
        {
            clsValidationResult validationResult = this.Validated();
                
            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            try
            {
                clsInvoiceDTO invoiceDTO = this.MappingToDTO();

                if (!clsInvoiceData.IssueInvoice(invoiceDTO))
                {
                    validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
                }
                else
                {
                    clsInvoiceService.CreateInstance().OnInvoiceIssued(invoiceDTO.InvoiceID.Value, invoiceDTO.InvoiceNo);
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
