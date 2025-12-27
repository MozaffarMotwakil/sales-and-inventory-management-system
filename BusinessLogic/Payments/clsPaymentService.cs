using System;
using System.Data;
using BusinessLogic.Interfaces;
using BusinessLogic.Invoices;
using BusinessLogic.Validation;
using DataAccess.Payments;
using DataAccess.Payments;

namespace BusinessLogic.Payments
{
    public class clsPaymentService : IEntityListManager<clsPayment>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsPaymentService _Instance;

        private clsPaymentService() { }

        public static clsPaymentService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsPaymentService();
            }

            return _Instance;
        }


        private void OnPaymentSaved(int paymentID, string paymentName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(paymentID, paymentName, mode));
        }

        private void OnPaymentDeleted(int paymentID, string paymentName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(paymentID, paymentName));
        }

        public bool Delete(int id)
        {
            throw new InvalidOperationException("لا يمكن حذف سجل دفع/قبض");
        }

        public DataTable GetAll()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static DateTime GetFirstPaymentDate()
        {
            return clsPaymentData.GetFirstPaymentDate();
        }

        public clsPayment Find(int id)
        {
            throw new NotImplementedException("لم يتم تنفيذ الدالة الخاصة بالبحث عن سند دفع/قبض");
        }

        public clsValidationResult IssuePayment(clsPayment payment)
        {
            clsValidationResult result = payment.Validated();

            if (!result.IsValid)
            {
                return result;
            }

            byte newInvoiceStatusID = 0;

            if (payment.PaymentAmount - payment.InvoiceInfo.RemainingAmount.GetValueOrDefault() == 0)
            {
                newInvoiceStatusID = ((byte)enPaymentStatus.Paid);
            }
            else
            {
                newInvoiceStatusID = ((byte)enPaymentStatus.PartiallyPaid);
            }

            bool isSaved = clsPaymentData.IssuePayment(payment.MappingToDTO(), newInvoiceStatusID);

            if (isSaved)
            {
                OnPaymentSaved(payment.PaymentID, null, enMode.Add);
            }
            else
            {
                result.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return result;
        }

    }
}
