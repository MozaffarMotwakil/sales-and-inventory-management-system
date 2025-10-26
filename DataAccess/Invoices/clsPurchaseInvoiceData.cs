
using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Invoices;

namespace DataAccess.Invoices
{
    public class clsPurchaseInvoiceData
    {
        public static DataTable GetAllPurchaseInvoices()
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetAllPurchaseInvoices"
                );
        }

    }
}
