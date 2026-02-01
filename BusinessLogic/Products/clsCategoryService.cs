using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic.Interfaces;
using BusinessLogic.Utilities;
using BusinessLogic.Validation;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsCategoryService : IEntityListManager<clsCategory>
    {
        public event EventHandler<EntitySavedEventArgs> EntitySaved;
        public event EventHandler<EntityDeletedEventArgs> EntityDeleted;

        private static clsCategoryService _Instance;

        private clsCategoryService() { }

        public static clsCategoryService CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new clsCategoryService();
            }

            return _Instance;
        }

        private void OnCategorySaved(int categoryID, string categoryName, enMode mode)
        {
            EntitySaved?.Invoke(this, new EntitySavedEventArgs(categoryID, categoryName, mode));
        }

        private void OnCategoryDeleted(int categoryID, string categoryName)
        {
            EntityDeleted?.Invoke(this, new EntityDeletedEventArgs(categoryID, categoryName));
        }

        public bool MarkAsActive(clsCategory category)
        {
            if (category.IsActive)
            {
                return true;
            }

            if (category.Mode == enMode.Update && clsCategoryData.SetActive(category.CategoryID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnCategorySaved(category.CategoryID ?? -1, category.CategoryName, enMode.Update);
                return true;
            }

            return false;
        }

        public bool MarkAsInActive(clsCategory category)
        {
            if (!category.IsActive)
            {
                return true;
            }

            if (category.Mode == enMode.Update && clsCategoryData.SetInActive(category.CategoryID ?? -1, clsAppSettings.CurrentUser.UserID))
            {
                OnCategorySaved(category.CategoryID ?? -1, category.CategoryName, enMode.Update);
                return true;
            }

            return false;
        }

        public clsCategory Find(int categoryID)
        {
            clsCategoryDTO categoryDTO = clsCategoryData.FindCategoryByID(categoryID);
            return categoryDTO is null ? null : new clsCategory(categoryDTO);
        }

        public bool Delete(int categoryID)
        {
            if (categoryID < 1)
            {
                return false;
            }

            clsCategory category = Find(categoryID);

            try
            {
                if (clsCategoryData.DeleteCategory(categoryID))
                {
                    OnCategoryDeleted(categoryID, category.CategoryName);
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
            return clsCategoryData.GetAllCategorys();
        }

        public static bool IsCategoryExists(int categoryID)
        {
            return clsCategoryData.IsCategoryExists(categoryID);
        }

        public static bool IsCategoryExistsByName(string categoryName)
        {
            return clsCategoryData.IsCategoryExistsByName(categoryName);
        }

        public static DataTable GetCategoriesList()
        {
            return clsCategoryData.GetCategoriesList();
        }

        public static DataTable GetActiveCategoriesList()
        {
            return clsUtils.GetActiveRecordsList(
                clsCategoryData.GetCategoriesList()
                );
        }

        public static string[] GetCategoryNames()
        {
            return clsUtils.GetColumnStringArray(
                clsCategoryData.GetCategoriesList(),
                "CategoryName"
                );
        }

        public clsValidationResult Validated(clsCategory category)
        {
            clsValidationResult validationResult = category.Validated();
            clsCategory currentCategoryInDB = Find(category.CategoryID.GetValueOrDefault());

            if ((category.Mode == enMode.Update && currentCategoryInDB.CategoryName != category.CategoryName && IsCategoryExistsByName(category.CategoryName)) ||
                (category.Mode == enMode.Add && IsCategoryExistsByName(category.CategoryName)))
            {
                validationResult.AddError("إسم الفئة/الصنف", "الفئة/الصنف موجودة بالفعل");
            }

            return validationResult;
        }

        public clsValidationResult Save(clsCategory category)
        {
            clsValidationResult validationResult = Validated(category);

            if (!validationResult.IsValid)
            {
                return validationResult;
            }

            return _ExecuteSaving(category.MappingToDTO(), category.Mode, validationResult);
        }

        private clsValidationResult _ExecuteSaving(clsCategoryDTO categoryDTO, enMode mode, clsValidationResult validationResult)
        {
            if (mode is enMode.Add)
            {
                categoryDTO.CreatedByUserID = clsAppSettings.CurrentUser.UserID;
            }
            else
            {
                categoryDTO.UpdatedByUserID = clsAppSettings.CurrentUser.UserID;
            }

            bool isSaved = mode is enMode.Add ?
                clsCategoryData.AddCategory(categoryDTO) :
                clsCategoryData.UpdateCategory(categoryDTO);

            if (isSaved)
            {
                OnCategorySaved(categoryDTO.CategoryID.GetValueOrDefault(), categoryDTO.CategoryName, mode);
            }
            else
            {
                validationResult.AddError("قاعدة البيانات", "فشل الحفظ في قاعدة البيانات");
            }

            return validationResult;
        }

    }
}