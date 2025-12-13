using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BusinessLogic.Discounts;
using BusinessLogic.Interfaces;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsDiscount : IEntityActivity
    {
        public enum enValueType
        {
            Percentage,
            Amount
        }

        public int? DiscountID { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountValue { get; set; }
        public enValueType DiscountValueType { get; set; }
        public int MinimumQuantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public clsUser UpdatedByUserInfo { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public enMode Mode { get; internal set; }
        public List<clsDiscountItem> Items => clsProductData.GetDiscountItems(this.DiscountID ?? -1)
                .AsEnumerable()
                .Select(discountItem =>
                {
                    return new clsDiscountItem
                    (
                       this.DiscountID.Value,
                       discountItem.Field<int>("ProductID"),
                       discountItem.Field<int>("UnitID")
                    );
                }
                ).ToList();

        public clsDiscount(string discountName, decimal discountValue, enValueType discountValueType,
            int minimumQuantity, DateTime startDate, DateTime endDate)
        {
            DiscountName = discountName;
            DiscountValue = discountValue;
            DiscountValueType = discountValueType;
            MinimumQuantity = minimumQuantity;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = true;
            Mode = enMode.Add;
        }

        internal clsDiscount(clsDiscountDTO discountDTO)
        {
            DiscountID = discountDTO.DiscountID;
            DiscountName = discountDTO.DiscountName;
            DiscountValue = discountDTO.DiscountValue;
            DiscountValueType = (enValueType)(discountDTO.DiscountValueType ? 0 : 1);
            MinimumQuantity = discountDTO.MinimumQuantity;
            StartDate = discountDTO.StartDate;
            EndDate = discountDTO.EndDate;
            IsActive = discountDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(discountDTO.CreatedByUserID ?? -1);
            CreatedAt = discountDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(discountDTO.UpdatedByUserID ?? -1);
            UpdatedAt = discountDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public bool GetActivityStatus()
        {
            return IsActive;
        }

        public bool MarkAsActive()
        {
            return clsDiscountService.CreateInstance().MarkAsActive(this);
        }

        public bool MarkAsInActive()
        {
            return clsDiscountService.CreateInstance().MarkAsInActive(this);
        }

        public clsDiscountDTO MappingToDTO()
        {
            return new clsDiscountDTO
            {
                DiscountID = this.DiscountID,
                DiscountName = this.DiscountName,
                DiscountValue = this.DiscountValue,
                DiscountValueType = ((byte)this.DiscountValueType) == 0 ? false : true,
                MinimumQuantity = this.MinimumQuantity,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                IsActive = this.IsActive,
                CreatedByUserID = this.CreatedByUserInfo?.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public void TrimAllStringFields()
        {
            this.DiscountName = this.DiscountName.Trim();
        }

        public bool SaveDiscountItems(List<clsDiscountItem> discountItems)
        {
            return clsDiscountService.CreateInstance().SaveDiscountItems(
                this,
                clsAppSettings.CurrentUser.UserID,
                discountItems
                );
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(this.DiscountName))
            {
                validationResult.AddError("إسم التخفيض", "لا يمكن أن يكون إسم المنتج فارغا");
            }

            if (!float.TryParse(DiscountValue.ToString(), out float sellingPrice) || sellingPrice < 1)
            {
                validationResult.AddError("قيمة التخفيض", "يجب أن يكون قيمة التخفيض رقم أكبر من صفر");
            }

            if (MinimumQuantity <= 0)
            {
                validationResult.AddError("الحد الأدنى للكمية", "يجب أن يكون الحد الأدنى للكمية أكبر من صفر.");
            }

            if (StartDate < DateTime.Today)
            {
                validationResult.AddError("تاريخ البداية", "لا يمكن أن يكون تاريخ بداية الخصم في الماضي.");
            }

            if (EndDate < DateTime.Today)
            {
                validationResult.AddError("تاريخ النهاية", "لا يمكن أن يكون تاريخ نهاية الخصم في الماضي.");
            }

            return validationResult;
        }

        public clsValidationResult Save()
        {
            return clsDiscountService.CreateInstance().Save(this);
        }

    }
}
