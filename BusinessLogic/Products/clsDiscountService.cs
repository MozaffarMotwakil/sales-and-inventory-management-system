using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Discounts
{
    public class clsDiscountService : IEntityListManager<clsDiscount>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsDiscountService _Instance;

        private clsDiscountService() { }

        public static clsDiscountService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsDiscountService();
            }

            return _Instance;
        }

        private void OnDiscountSaved(int discountID, string discountName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(discountID, discountName, mode));
        }

        private void OnDiscountDeleted(int discountID, string discountName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(discountID, discountName));
        }

        public bool MarkAsActive(clsDiscount discount)
        {
            if (discount.IsActive)
            {
                return true;
            }

            if (discount.Mode == enMode.Update && clsDiscountData.SetActive(discount.DiscountID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnDiscountSaved(discount.DiscountID ?? -1, discount.DiscountName, enMode.Update);
                return true;
            }

            return false;
        }

        public bool MarkAsInActive(clsDiscount discount)
        {
            if (!discount.IsActive)
            {
                return true;
            }

            if (discount.Mode == enMode.Update && clsDiscountData.SetInActive(discount.DiscountID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnDiscountSaved(discount.DiscountID ?? -1, discount.DiscountName, enMode.Update);
                return true;
            }

            return false;
        }

        public clsDiscount Find(int discountID)
        {
            if (discountID < 1)
            {
                return null;
            }

            clsDiscountDTO discountDTO = clsDiscountData.FindDiscountByID(discountID);
            return discountDTO is null ? null : new clsDiscount(discountDTO);
        }

        public bool Delete(int discountID)
        {
            if (discountID < 1)
            {
                return false;
            }

            clsDiscount discount = Find(discountID);

            try
            {
                if (clsDiscountData.DeleteDiscount(discountID))
                {
                    OnDiscountDeleted(discountID, discount.DiscountName);
                    return true;
                }
            }
            catch (SqlException ex) when (ex.Number >= 50000)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(clsAppSettings.ErrorToConnectionFormDB, ex);
            }

            return false;
        }

        public DataTable GetAll()
        {
            return clsDiscountData.GetAllDiscounts();
        }

        public bool SaveDiscountItems(clsDiscount discount, int linkedByUserID, List<clsDiscountItem> discountItems)
        {
            if (clsProductData.LinkingDiscountToProducts(
                discount.DiscountID ?? -1,
                linkedByUserID,
                clsDiscountItem.ConvertDiscountItemsListToTable(discountItems)
                ))
            {
                OnDiscountSaved(discount.DiscountID ?? -1, discount.DiscountName, enMode.Add);
                return true;
            }

            return false;
        }

        public static bool IsDiscountExistsByName(string discountName)
        {
            return clsDiscountData.IsDiscountExistsByName(discountName);
        }

        public clsValidationResult Validated(clsDiscount discount)
        {
            clsValidationResult validationResult = discount.Validated();
            clsDiscount currentProductInDB = Find(discount.DiscountID ?? -1);

            if ((discount.Mode == enMode.Update && currentProductInDB.DiscountName != discount.DiscountName && IsDiscountExistsByName(discount.DiscountName)) ||
                (discount.Mode == enMode.Add && IsDiscountExistsByName(discount.DiscountName)))
            {
                validationResult.AddError("إسم الخصم", "الخصم موجود بالفعل");
            }

            return validationResult;
        }

        public clsValidationResult Save(clsDiscount discount)
        {
            clsValidationResult validationResult = Validated(discount);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            return _ExecuteSaving(discount.MappingToDTO(), discount.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsDiscountDTO discountDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                discountDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                discountDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
            }

            bool isSaved = mode is enMode.Add ?
                clsDiscountData.AddDiscount(discountDTO) :
                clsDiscountData.UpdateDiscount(discountDTO);

            if (isSaved)
            {
                OnDiscountSaved(discountDTO.DiscountID ?? -1, discountDTO.DiscountName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}
