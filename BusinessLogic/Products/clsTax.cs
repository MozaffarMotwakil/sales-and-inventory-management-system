using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BusinessLogic.Interfaces;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsTax : IEntityActivity
    {
        public int? TaxID { get; set; }
        public string TaxName { get; set; }
        public decimal TaxRate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public clsUser UpdatedByUserInfo { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public enMode Mode { get; internal set; }
        public List<clsTaxItem> Items => clsTaxData.GetTaxItems(this.TaxID ?? -1)
                .AsEnumerable()
                .Select(TaxItem =>
                {
                    return new clsTaxItem
                    (
                       this.TaxID.Value,
                       TaxItem.Field<int>("ProductID")
                    );
                }
                ).ToList();


        public clsTax(string taxName, decimal taxRate, string description)
        {
            TaxName = taxName;
            TaxRate = taxRate;
            Description = description;
            IsActive = true;
            Mode = enMode.Add;
        }

        internal clsTax(clsTaxDTO TaxDTO)
        {
            TaxID = TaxDTO.TaxID;
            TaxName = TaxDTO.TaxName;
            TaxRate = TaxDTO.TaxRate;
            Description = TaxDTO.Description;
            IsActive = TaxDTO.IsActive;
            CreatedByUserInfo = clsUser.Find(TaxDTO.CreatedByUserID ?? -1);
            CreatedAt = TaxDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(TaxDTO.UpdatedByUserID ?? -1);
            UpdatedAt = TaxDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public bool GetActivityStatus()
        {
            return IsActive;
        }

        public bool MarkAsActive()
        {
            return clsTaxService.CreateInstance().MarkAsActive(this);
        }

        public bool MarkAsInActive()
        {
            return clsTaxService.CreateInstance().MarkAsInActive(this);
        }

        public clsTaxDTO MappingToDTO()
        {
            return new clsTaxDTO
            {
                TaxID = this.TaxID,
                TaxName = this.TaxName,
                TaxRate = this.TaxRate,
                Description = this.Description,
                IsActive = this.IsActive,
                CreatedByUserID = this.CreatedByUserInfo?.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public void TrimAllStringFields()
        {
            this.TaxName = this.TaxName.Trim();
            this.Description = this.Description.Trim();
        }

        public bool SaveTaxItems(List<clsTaxItem> TaxItems)
        {
            return clsTaxService.CreateInstance().SaveTaxItems(
                this,
                clsAppSettings.CurrentUser.UserID,
                TaxItems
                );
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(this.TaxName))
            {
                validationResult.AddError("إسم الضريبة", "لا يمكن أن يكون إسم الضريبة فارغا");
            }

            if (!decimal.TryParse(TaxRate.ToString(), out decimal taxRate) || taxRate < 1)
            {
                validationResult.AddError("معدل الضريبة", "يجب أن يكون معدل الضريبة رقم أكبر من صفر");
            }

            return validationResult;
        }

        public clsValidationResult Save()
        {
            return clsTaxService.CreateInstance().Save(this);
        }

    }
}
