using System;

namespace DTOs.Products
{
    public class clsUnitDTO
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public clsUnitDTO() { }

        public clsUnitDTO(int unitID, string unitName)
        {
            UnitID = unitID;
            UnitName = unitName;
        }
    }
}
