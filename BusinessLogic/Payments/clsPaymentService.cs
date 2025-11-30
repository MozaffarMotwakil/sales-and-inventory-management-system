using System;
using System.Data;
using BusinessLogic.Interfaces;
using BusinessLogic.Warehouses;
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

    }
}
