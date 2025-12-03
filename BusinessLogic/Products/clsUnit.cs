using System.Data;
using BusinessLogic.Utilities;
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

        public static DataTable GetUnitsList()
        {
            return clsProductUnitData.GetUnitsList();
        }

        public static string[] GetAllUnitNames()
        {
            return clsUtils.GetColumnStringArray(
                clsProductUnitData.GetUnitsList(),
                "UnitName"
                );
        }

    }
}
