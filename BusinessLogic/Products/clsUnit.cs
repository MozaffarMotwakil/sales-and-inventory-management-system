using System.Data;
using System.Linq;
using DataAccess.Products;
using DTOs.Products;

namespace BusinessLogic.Products
{
    public class clsUnit
    {
        public int UnitID { get; }
        public string UnitName { get; }

        private clsUnit(clsUnitDTO unitDTO)
        {
            UnitID = unitDTO.UnitID;
            UnitName = unitDTO.UnitName;
        }

        public static clsUnit Find(int unitID)
        {
            clsUnitDTO unitDTO = clsProductUnitData.FindProductUnitByID(unitID);
            return unitDTO is null ? null : new clsUnit(unitDTO);
        }

        public static object[] GetAllUnitNames()
        {
            return clsProductUnitData.GetAllProductUnitNames()
                .Rows
                .Cast<DataRow>()
                .Select(row => row[0])
                .ToArray();
        }

    }
}
