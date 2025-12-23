using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Payments;

namespace DataAccess.Payments
{
    public static class clsPaymentData
    {
        public static bool IssuePayment(clsPaymentDTO paymentDTO, int newInvoiceStatusID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Payments_IssuePayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PaymentAmount", paymentDTO.PaymentAmount);
                    command.Parameters.AddWithValue("@PaymentMethodID", paymentDTO.PaymentMethodID);
                    command.Parameters.AddWithValue("@PaymentDate", paymentDTO.PaymentDate);
                    command.Parameters.AddWithValue("@InvoiceID", paymentDTO.InvoiceID);
                    command.Parameters.AddWithValue("@NewInvoiceStatusID", newInvoiceStatusID);
                    command.Parameters.AddWithValue("@CreatedByUserID", paymentDTO.CreatedByUserID);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

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
