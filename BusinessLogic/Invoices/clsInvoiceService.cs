using System;
using System.Data;
using BusinessLogic.Interfaces;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsInvoiceService : IEntityListManager<clsInvoice>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsInvoiceService _Instance;

        private clsInvoiceService() { }

        public static clsInvoiceService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsInvoiceService();
            }

            return _Instance;
        }

        public void OnInvoiceIssued(int invoiceID, string invoiceNumber)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(invoiceID, invoiceNumber, enMode.Add));
        }

        public static bool IsInvoiceExists(int invoiceID)
        {
            return clsInvoiceData.IsInvoiceExists(invoiceID);
        }

        public static bool IsInvoiceExists(string invoiceNa)
        {
            return clsInvoiceData.IsInvoiceExists(invoiceNa);
        }

        public clsInvoice Find(int InvoiceID)
        {
            if (InvoiceID < 1)
            {
                return null;
            }

            clsInvoiceDTO InvoiceDTO = clsInvoiceData.FindInvoiceByID(InvoiceID);

            switch (InvoiceDTO?.InvoiceTypeID)
            {
                case (byte)enInvoiceType.Purchase:
                    return new clsPurchaseInvoice(InvoiceDTO);
                case (byte)enInvoiceType.PurchaseReturn:
                    return new clsPurchaseReturnInvoice(InvoiceDTO);
                case (byte)enInvoiceType.Sales:
                    return null;
                case (byte)enInvoiceType.SalesReturn:
                    return null;
                default:
                    return null;
            }
        }

        public bool Delete(int purchaseInvoiceID)
        {
            throw new InvalidOperationException("لا يمكن حذف فاتورة قد تم إصدارها");
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException("لم يتم إنشاء دالة جلب كل فواتير");
        }

        public DataTable GetAllPurchaseInvoices()
        {
            return clsInvoiceData.GetAllPurchaseInvoices();
        }

        public DataTable GetAllSaleInvoices()
        {
            throw new NotImplementedException("لم يتم إنشاء دالة جلب كل فواتير المشتريات");
        }

    }
}
