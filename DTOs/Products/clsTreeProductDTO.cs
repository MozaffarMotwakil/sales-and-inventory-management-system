using System;
using System.Collections.Generic;

namespace DTOs.Products
{
    public class clsTreeProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public List<clsTreeUnitDTO> Units { get; set; }
    }
}
