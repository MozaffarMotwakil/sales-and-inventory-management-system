using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Invoices;

namespace DataAccess.Invoices
{
    public static class clsInvoiceData
    {
        public static clsInvoiceDTO FindInvoiceByID(int invoiceID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Invoices_GetByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            clsInvoiceDTO invoicetDTO = null;

                            if (reader.Read())
                            {
                                invoicetDTO = new clsInvoiceDTO()
                                {
                                    InvoiceID = Convert.ToInt32(reader["InvoiceID"]),
                                    InvoiceNo = Convert.ToString(reader["InvoiceNa"]),
                                    InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]),
                                    InvoiceTypeID = Convert.ToByte(reader["InvoiceTypeID"]),
                                    InvoiceStatusID = Convert.ToByte(reader["InvoiceStatusID"]),
                                    TotalSubTotal = Convert.ToDecimal(reader["TotalSubTotal"]),
                                    TotalDiscountAmount = Convert.ToDecimal(reader["TotalDiscountAmount"]),
                                    TotalTaxAmount = Convert.ToDecimal(reader["TotalTaxAmount"]),
                                    GrandTotal = Convert.ToDecimal(reader["GrandTotal"]),
                                    PaymentMethodID = reader["PaymentMethodID"] != DBNull.Value ?
                                        Convert.ToByte(reader["PaymentMethodID"]) :
                                        (byte?)null,
                                    PaymentAmount = reader["PaymentAmount"] != DBNull.Value ?
                                        Convert.ToDecimal(reader["PaymentAmount"]) :
                                        (decimal?)null,
                                    PartyID = reader["PartyID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["PartyID"]),
                                    WarehouseID = Convert.ToInt32(reader["WarehouseID"]),
                                    OriginalInvoiceID = reader["OriginalInvoiceID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["OriginalInvoiceID"]),
                                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                                };

                                if (reader.NextResult())
                                {
                                    if (reader.HasRows)
                                    {
                                        DataTable invoiceLines = new DataTable();
                                        invoiceLines.Load(reader);
                                        invoicetDTO.Lines = invoiceLines;
                                    }
                                }
                            }

                            return invoicetDTO;
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

                    command.Parameters.AddWithValue("@InvoiceNa", invoiceDTO.InvoiceNo);
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

        public static DataTable GetAllPurchaseInvoices()
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetAllPurchaseInvoices"
                );
        }

        public static DataTable GetAllSaleInvoices()
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetAllSaleInvoices"
                );
        }

        public static DataTable GetDiscountsForSaleLine(int lineID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetDiscountsForSaleLine", 
                "@LineID",
                lineID
                );
        }

        public static DataTable GetTaxesForSaleLine(int lineID)
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetTaxesForSaleLine", 
                "@LineID",
                lineID
                );
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

        public static int GetSaleInvoicesCount()
        {
            return Convert.ToInt32(
                clsDataSettings.GetSingleValue("usp_Invoices_GetSaleInvoicesCount")
                );
        }

        public static int GetReturnInvoicesCount(int invoiceID)
        {
            return Convert.ToInt32(clsDataSettings.GetSingleValue(
                "usp_Invoices_GetReturnInvoicesCount",
                "@InvoiceID",
                invoiceID
                ));
        }

        public static int GetInvoiceLineRemainingQuantity(int lineID)
        {
            return Convert.ToInt32(clsDataSettings.GetSingleValue(
                "usp_Inventories_GetInvoiceLineRemainingQuantity",
                "@LineID",
                lineID
                ));
        }

        public static DateTime GetFirstPurchaseInvoiceDate()
        {
            return Convert.ToDateTime(
                clsDataSettings.GetSingleValue("usp_Invoices_GetFirstPurchaseInvoiceDate")
                );
        }

        public static DateTime GetFirstSaleInvoiceDate()
        {
            return Convert.ToDateTime(
                clsDataSettings.GetSingleValue("usp_Invoices_GetFirstSaleInvoiceDate")
                );
        }

    }
}
