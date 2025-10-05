using System;

namespace DTOs.Products
{
    public class clsCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public clsCategoryDTO() { }

        public clsCategoryDTO(int gategoryID, string gategoryName)
        {
            CategoryID = gategoryID;
            CategoryName = gategoryName;
        }
    }
}
