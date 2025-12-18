using System;
using System.Collections.Generic;
using DataAccess.Invoices;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsSaleInvoice : clsInvoice
    {
        public clsSaleInvoice(DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, int? customerID, int warehouseID, enPaymentMethod? paymentMethod, decimal? paymentAmount) :
            base(null, "SI-" + DateTime.Today.Year + '-' + (GetSaleInvoicesCount() + 1), invoiceDate, enInvoiceType.Sales, invoiceStatus, lines, warehouseID, paymentMethod, paymentAmount,
                null, null)
        {

        }

        internal clsSaleInvoice(clsInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceID, invoiceDTO.InvoiceNo, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enInvoiceStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines, (enInvoiceType)invoiceDTO.InvoiceTypeID),
                invoiceDTO.WarehouseID, (enPaymentMethod?)invoiceDTO.PaymentMethodID, invoiceDTO.PaymentAmount, invoiceDTO.CreatedByUserID,
                invoiceDTO.CreatedAt)
        {

        }

        public static int GetSaleInvoicesCount()
        {
            return clsInvoiceData.GetSaleInvoicesCount();
        }

        public static DateTime GetFirstSaleInvoiceDate()
        {
            return clsInvoiceData.GetFirstSaleInvoiceDate();
        }

        protected override clsInvoiceDTO MappingToDTO()
        {
            return new clsInvoiceDTO
            {
                InvoiceID = this.InvoiceID,
                InvoiceNo = this.InvoiceNo,
                InvoiceDate = this.InvoiceDate,
                InvoiceTypeID = (byte)this.InvoiceType,
                InvoiceStatusID = (byte)this.InvoiceStatus,
                PartyID = null,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte?)this.PaymentMethod,
                PaymentAmount = this.PaymentAmount,
                WarehouseID = this?.WarehouseInfo?.WarehouseID ?? -1,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public override string GetPartyName()
        {
            return "N/A";
        }

    }
}
