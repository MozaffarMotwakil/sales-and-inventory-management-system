using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Invoices;

namespace DataAccess.Invoices
{
    public static class clsInvoiceData
    {
        public static bool IssueInvoice(clsInvoiceDTO invoice)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Invoices_Issue", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@InvoiceNa", invoice.InvoiceNa);
                    command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
                    command.Parameters.AddWithValue("@InvoiceTypeID", invoice.InvoiceTypeID);
                    command.Parameters.AddWithValue("@InvoiceStatusID", invoice.InvoiceStatusID);
                    command.Parameters.AddWithValue("@PartyID", invoice.PartyID);
                    command.Parameters.AddWithValue("@TotalSubTotal", invoice.TotalSubTotal);
                    command.Parameters.AddWithValue("@TotalDiscountAmount", invoice.TotalDiscountAmount);
                    command.Parameters.AddWithValue("@TotalTaxAmount", invoice.TotalTaxAmount);
                    command.Parameters.AddWithValue("@GrandTotal", invoice.GrandTotal);
                    command.Parameters.AddWithValue("@OriginalInvoiceID", clsDataSettings.GetDBNullIfNull(invoice.OriginalInvoiceID));
                    command.Parameters.AddWithValue("@PaymentMethodID", clsDataSettings.GetDBNullIfNull(invoice.PaymentMethodID));
                    command.Parameters.AddWithValue("@CashPaidAmount", clsDataSettings.GetDBNullIfNull(invoice.CashPaidAmount));
                    command.Parameters.AddWithValue("@CreatedByUserID", invoice.CreatedByUserID);

                    SqlParameter tvpParam = command.Parameters.AddWithValue("@InvoiceLines", invoice.Lines);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "InvoiceLineType";

                    SqlParameter outputParam = new SqlParameter("@NewInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    SqlParameter returnValueParam = new SqlParameter
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnValueParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (outputParam.Value != DBNull.Value)
                        {
                            invoice.InvoiceID = (int)outputParam.Value;
                        }

                        return (int)returnValueParam.Value == 1;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool IsInvoiceExists(int invoiceID)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Invoices_IsExistsByID",
                "@InvoiceID",
                invoiceID
                );
        }

        public static bool IsInvoiceExists(string invoiceNa)
        {
            return clsDataSettings.ExecuteSimpleSP(
                "usp_Invoices_IsExistsByInvoiceNa",
                "@InvoiceNa",
                invoiceNa
                );
        }

    }
}
