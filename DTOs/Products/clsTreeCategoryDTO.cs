using System;
using System.Collections.Generic;

namespace DTOs.Products
{
    public class clsTreeCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<clsTreeProductDTO> Products { get; set; }
    }
}
