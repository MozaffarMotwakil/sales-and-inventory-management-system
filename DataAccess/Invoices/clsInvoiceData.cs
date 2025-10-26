using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Invoices;

namespace DataAccess.Invoices
{
    public static class clsInvoiceData
    {
        public static clsInvoiceDTO FindInvoiceByID(int purchaseInvoiceID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Invoices_GetByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceID", purchaseInvoiceID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsPurchaseInvoiceDTO purchaseInvoicetDTO = null;

                            if (reader.Read())
                            {
                                purchaseInvoicetDTO = new clsPurchaseInvoiceDTO
                                {
                                    InvoiceID = Convert.ToInt32(reader["InvoiceID"]),
                                    InvoiceNa = Convert.ToString(reader["InvoiceNa"]),
                                    InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]),
                                    InvoiceTypeID = Convert.ToByte(reader["InvoiceTypeID"]),
                                    InvoiceStatusID = Convert.ToByte(reader["InvoiceStatusID"]),
                                    TotalSubTotal = Convert.ToDecimal(reader["TotalSubTotal"]),
                                    TotalDiscountAmount = Convert.ToDecimal(reader["TotalDiscountAmount"]),
                                    TotalTaxAmount = Convert.ToDecimal(reader["TotalTaxAmount"]),
                                    GrandTotal = Convert.ToDecimal(reader["GrandTotal"]),
                                    PaymentMethodID = Convert.ToByte(reader["PaymentMethodID"]),
                                    PaymentAmount = Convert.ToDecimal(reader["PaymentAmount"]),
                                    PartyID = Convert.ToInt32(reader["PartyID"]),
                                    WarehouseID = Convert.ToInt32(reader["WarehouseID"]),
                                    OriginalInvoiceID = (reader["OriginalInvoiceID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["OriginalInvoiceID"])),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                if (reader.NextResult())
                                {
                                    if (reader.HasRows)
                                    {
                                        DataTable invoiceLines = new DataTable();
                                        invoiceLines.Load(reader);
                                        purchaseInvoicetDTO.Lines = invoiceLines;
                                    }
                                }
                            }

                            return purchaseInvoicetDTO;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }

        public static bool IssueInvoice(clsInvoiceDTO invoiceDTO)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Invoices_Issue", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@InvoiceNa", invoiceDTO.InvoiceNa);
                    command.Parameters.AddWithValue("@InvoiceDate", invoiceDTO.InvoiceDate);
                    command.Parameters.AddWithValue("@InvoiceTypeID", invoiceDTO.InvoiceTypeID);
                    command.Parameters.AddWithValue("@InvoiceStatusID", invoiceDTO.InvoiceStatusID);
                    command.Parameters.AddWithValue("@TotalSubTotal", invoiceDTO.TotalSubTotal);
                    command.Parameters.AddWithValue("@TotalDiscountAmount", invoiceDTO.TotalDiscountAmount);
                    command.Parameters.AddWithValue("@TotalTaxAmount", invoiceDTO.TotalTaxAmount);
                    command.Parameters.AddWithValue("@GrandTotal", invoiceDTO.GrandTotal);
                    command.Parameters.AddWithValue("@PaymentMethodID", clsDataSettings.GetDBNullIfNull(invoiceDTO.PaymentMethodID));
                    command.Parameters.AddWithValue("@PaymentAmount", clsDataSettings.GetDBNullIfNull(invoiceDTO.PaymentAmount));
                    command.Parameters.AddWithValue("@PartyID", invoiceDTO.PartyID);
                    command.Parameters.AddWithValue("@WarehouseID", invoiceDTO.WarehouseID);
                    command.Parameters.AddWithValue("@OriginalInvoiceID", clsDataSettings.GetDBNullIfNull(invoiceDTO.OriginalInvoiceID));
                    command.Parameters.AddWithValue("@CreatedByUserID", invoiceDTO.CreatedByUserID);

                    SqlParameter tvpParam = command.Parameters.AddWithValue("@InvoiceLines", invoiceDTO.Lines);
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
                            invoiceDTO.InvoiceID = (int)outputParam.Value;
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
