using System;
using System.Data;
using BusinessLogic.Interfaces;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    /// <summary>
    /// This class is represent a server class for purchases and return purchases invoices
    /// </summary>
    public class clsPurchaseInvoiceService : IEntityListManager<clsInvoice>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsPurchaseInvoiceService _Instance;

        private clsPurchaseInvoiceService() { }

        public static clsPurchaseInvoiceService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsPurchaseInvoiceService();
            }

            return _Instance;
        }

        public void OnPurchaseInvoiceIssued(int purchaseInvoiceID, string purchaseInvoiceNumber, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(purchaseInvoiceID, purchaseInvoiceNumber, mode));
        }

        public clsInvoice Find(int purchaseInvoiceID)
        {
            if (purchaseInvoiceID < 1)
            {
                return null;
            }

            clsPurchaseInvoiceDTO purchaseInvoiceDTO = clsInvoiceData.FindInvoiceByID(purchaseInvoiceID) as clsPurchaseInvoiceDTO;
            return purchaseInvoiceDTO is null ? null : new clsPurchaseInvoice(purchaseInvoiceDTO);
        }

        /// <summary>
        /// This method is always throw an exception becuse connot delete an invoice after its issued
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public bool Delete(int purchaseInvoiceID)
        {
            throw new InvalidOperationException("لا يمكن حذف فاتورة قد تم إصدارها");
        }

        public DataTable GetAll()
        {
            return clsPurchaseInvoiceData.GetAllPurchaseInvoices();
        }

    }
}
