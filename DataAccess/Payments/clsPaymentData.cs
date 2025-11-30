using System;
using System.Data;

namespace DataAccess.Payments
{
    public static class clsPaymentData
    {
        public static DataTable GetAllPayments()
        {
            return clsDataSettings.GetDataTable(
                "usp_Payments_GetAllPayments"
                );
        }
        
        public static DateTime GetFirstPaymentDate()
        {
            return Convert.ToDateTime(
                clsDataSettings.GetSingleValue("usp_Payments_GetFirstPaymentDate")
                );
        }

    }
}
