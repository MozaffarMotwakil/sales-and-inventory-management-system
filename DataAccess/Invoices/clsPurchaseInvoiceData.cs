
using System;
using System.Data;
using System.Data.SqlClient;
using DTOs.Invoices;

namespace DataAccess.Invoices
{
    public class clsPurchaseInvoiceData
    {
        public static clsPurchaseInvoiceDTO FindPurchaseInvoiceByID(int purchaseInvoiceID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Invoices_GetPurchasesInvoiceByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PurchasesInvoiceID", purchaseInvoiceID);

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
                                    InvoiceID = Convert.ToInt32("InvoiceID"),
                                    InvoiceNa = Convert.ToString("InvoiceNa"),
                                    InvoiceDate = Convert.ToDateTime("InvoiceDate"),
                                    InvoiceTypeID = Convert.ToByte("InvoiceTypeID"),
                                    InvoiceStatusID = Convert.ToByte("InvoiceStatusID"),
                                    SupplierID = Convert.ToInt32("SupplierID"),
                                    TotalSubTotal = Convert.ToDecimal("TotalSubTotal"),
                                    TotalDiscountAmount = Convert.ToDecimal("TotalDiscountAmount"),
                                    TotalTaxAmount = Convert.ToDecimal("TotalTaxAmount"),
                                    GrandTotal = Convert.ToDecimal("GrandTotal"),
                                    PaymentMethodID = Convert.ToByte("PaymentMethodID"),
                                    CashPaidAmount = Convert.ToDecimal("CashPaidAmount"),
                                    CreatedByUserID = Convert.ToInt32("CreatedByUserID"),
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

        public static DataTable GetAllPurchaseInvoices()
        {
            return clsDataSettings.GetDataTable(
                "usp_Invoices_GetAllPurchaseInvoices"
                );
        }

    }
}
