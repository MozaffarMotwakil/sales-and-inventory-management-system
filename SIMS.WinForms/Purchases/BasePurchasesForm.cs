using System;
using BusinessLogic.Invoices;
using SIMS.WinForms.BaseForms;

namespace SIMS.WinForms.Purchases
{
    public class BasePurchasesForm : frmGenericListBase<clsPurchaseInvoiceService, clsPurchaseInvoice>
    {
        public BasePurchasesForm() : base(clsPurchaseInvoiceService.CreateInstance())
        {

        }
    }
}
