using System.Data;
using DataAccess.Products;
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

        public static string[] GetCategoryNames()
        {
            DataTable categoryTable = clsProductCategoryData.GetAllProductCategoryNames();
            string[] categoryNames = new string[categoryTable.Rows.Count];

            for (int i = 0; i < categoryNames.Length; i++)
            {
                categoryNames[i] = categoryTable.Rows[i][0].ToString();
            }

            return categoryNames;
        }

    }
}
