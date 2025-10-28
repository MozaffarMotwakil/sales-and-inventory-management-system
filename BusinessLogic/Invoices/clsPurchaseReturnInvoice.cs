using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Suppliers;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DTOs.Invoices;

namespace BusinessLogic.Invoices
{
    public class clsPurchaseReturnInvoice : clsInvoice
    {
        public clsSupplier Supplier { get; }
        public clsPurchaseInvoice OriginalInvoiceInfo { get; set; }

        public clsPurchaseReturnInvoice(int originalInvoiceID, DateTime invoiceDate, enInvoiceStatus invoiceStatus,
            List<clsInvoiceLine> lines, int supplierID, int warehouseID, enPaymentMethod? paymentMethod, decimal? cashPaidAmount) :
            base(null, string.Empty, invoiceDate, enInvoiceType.PurchaseReturn, invoiceStatus, lines, warehouseID, paymentMethod, cashPaidAmount)
        {
            Supplier = clsSupplierService.CreateInstance().Find(supplierID);
            OriginalInvoiceInfo = clsInvoiceService.CreateInstance().Find(originalInvoiceID) as clsPurchaseInvoice;
            InvoiceNo = OriginalInvoiceInfo != null ? "PR-" + DateTime.Today.Year + '-' + OriginalInvoiceInfo.InvoiceNo + '-' + (clsInvoiceService.GetReturnInvoicesCount(OriginalInvoiceInfo?.InvoiceID ?? -1) + 1) : null;
        }

        internal clsPurchaseReturnInvoice(clsInvoiceDTO invoiceDTO) :
            base(invoiceDTO.InvoiceID, invoiceDTO.InvoiceNo, invoiceDTO.InvoiceDate, (enInvoiceType)invoiceDTO.InvoiceTypeID,
                (enInvoiceStatus)invoiceDTO.InvoiceStatusID, clsInvoiceLine.ConvertInvoiceLinesDataTableToList(invoiceDTO.Lines),
                invoiceDTO.WarehouseID, (enPaymentMethod)invoiceDTO.PaymentMethodID, invoiceDTO.PaymentAmount)
        {
            Supplier = clsSupplierService.CreateInstance().FindByPartyID(invoiceDTO.PartyID ?? -1);
            OriginalInvoiceInfo = clsInvoiceService.CreateInstance().Find(invoiceDTO.OriginalInvoiceID.Value) as clsPurchaseInvoice;
            CreatedByUserInfo = clsUser.Find(invoiceDTO.CreatedByUserID.Value);
            CreateAt = invoiceDTO.CreatedAt;
        }

        public override clsValidationResult Validated()
        {
            clsValidationResult validationResult = base.Validated();

            if (Supplier == null)
            {
                validationResult.AddError("المورد", "يجب تعيين مورد للفاتورة");
            }
            
            if (OriginalInvoiceInfo == null)
            {
                validationResult.AddError("الفاتورة الأصلية", "يجب أن تستند فاتورة المرتجعات على فاتورة أصلية");
            }

            if (Lines != null && OriginalInvoiceInfo != null)
            {
                foreach (clsInvoiceLine line in Lines)
                {
                    clsInvoiceLine oppositeLine = OriginalInvoiceInfo.Lines.First(opLine => opLine.ProductID == line.ProductID && opLine.UnitID == line.UnitID);

                    if (line.Quantity > oppositeLine.GetRemainingQuantity())
                    {
                        validationResult.AddError(line.ProductInfo.ProductName, "لا يمكن إرجاع كمية أكبر من الكمية المشتراة المتبقية من هذا المنتج");
                    }

                    if (line.Quantity > clsInventory.GetInventoryQuantity(this.WarehouseInfo.WarehouseID ?? -1, line.ProductID, line.UnitID))
                    {
                        validationResult.AddError(line.ProductInfo.ProductName, "كمية البضاعة التي يراد إرجاعها أكبر من كمية المخزون الحالي");
                    }
                }
            }

            if (InvoiceType != enInvoiceType.PurchaseReturn)
            {
                validationResult.AddError("نوع الفاتورة", "الرجاء التأكد من أن نوع الفاتورة المحددة هو 'مرتجعات مشتريات'.");
            }

            return validationResult;
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
                PartyID = this.Supplier?.PartyInfo.PartyID,
                Lines = clsInvoiceLine.ConvertInvoiceLinesListToDataTable(base.Lines),
                TotalSubTotal = this.TotalSubTotal,
                TotalDiscountAmount = this.TotalDiscountAmount,
                TotalTaxAmount = this.TotalTaxAmount,
                GrandTotal = this.GrandTotal,
                PaymentMethodID = (byte)this.PaymentMethod,
                PaymentAmount = this.PaymentAmount,
                WarehouseID = this?.WarehouseInfo?.WarehouseID ?? -1,
                OriginalInvoiceID = OriginalInvoiceInfo?.InvoiceID,
                CreatedByUserID = clsAppSettings.CurrentUser.UserID,
            };
        }

        public override string GetPartyName()
        {
            return Supplier == null ? "N/A" : Supplier.PartyInfo.PartyName;
        }

    }
}