using System;
using System.Data;
using System.Linq;
using BusinessLogic.Utilities;
using DataAccess.Products;
using DataAccess.Warehouses;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsCategory
    {
        public int CategoryID { get; }
        public string CategoryName { get; }

        private clsCategory(clsCategoryDTO categoryDTO)
        {
            CategoryID = categoryDTO.CategoryID;
            CategoryName = categoryDTO.CategoryName;
        }

        public static clsCategory Find(int categoryID)
        {
            clsCategoryDTO categoryDTO = clsProductCategoryData.FindProductCategoryByID(categoryID);
            return categoryDTO is null ? null : new clsCategory(categoryDTO);
        }

        public static DataTable GetCategoryList()
        {
            return clsProductCategoryData.GetCategoriesList();
        }

        public static string[] GetCategoryNames()
        {
            return clsUtils.GetColumnStringArray(
                clsProductCategoryData.GetCategoriesList(),
                "CategoryName"
                );
        }

    }
}
