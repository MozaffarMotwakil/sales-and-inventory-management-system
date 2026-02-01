using System;
using BusinessLogic.Users;
using BusinessLogic.Validation;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsUnit
    {
        public int? UnitID { get; }
        public string UnitName { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public clsUser UpdatedByUserInfo { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public enMode Mode { get; internal set; }

        public clsUnit(string unitName)
        {
            UnitName = unitName;
            Mode = enMode.Add;
        }

        internal clsUnit(clsUnitDTO unitDTO)
        {
            UnitID = unitDTO.UnitID;
            UnitName = unitDTO.UnitName;
            CreatedByUserInfo = clsUser.Find(unitDTO.CreatedByUserID.GetValueOrDefault());
            CreatedAt = unitDTO.CreatedAt;
            UpdatedByUserInfo = clsUser.Find(unitDTO.UpdatedByUserID.GetValueOrDefault());
            UpdatedAt = unitDTO.UpdatedAt;
            Mode = enMode.Update;
        }

        public clsUnitDTO MappingToDTO()
        {
            return new clsUnitDTO
            {
                UnitID = this.UnitID.GetValueOrDefault(),
                UnitName = this.UnitName,
                CreatedByUserID = this.CreatedByUserInfo?.UserID,
                UpdatedByUserID = this.UpdatedByUserInfo?.UserID
            };
        }

        public void TrimAllStringFields()
        {
            UnitName = UnitName.Trim();
        }

        public clsValidationResult Validated()
        {
            clsValidationResult validationResult = new clsValidationResult();
            TrimAllStringFields();

            if (string.IsNullOrWhiteSpace(UnitName))
            {
                validationResult.AddError("إسم الوحدة", "لا يمكن أن يكون إسم الوحدة فارغا");
            }

            return validationResult;
        }

        public clsValidationResult Save()
        {
            return clsUnitService.CreateInstance().Save(this);
        }

    }
}
