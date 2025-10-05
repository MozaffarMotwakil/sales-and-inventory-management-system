using System.Data;
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

        public static string[] GetUnitNames()
        {
            DataTable unitTable = clsProductUnitData.GetAllProductUnitNames();
            string[] unitNames = new string[unitTable.Rows.Count];

            for (int i = 0; i < unitNames.Length; i++)
            {
                unitNames[i] = unitTable.Rows[i][0].ToString();
            }

            return unitNames;
        }

    }
}
