using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLogic.Products
{
    public class clsProductUnitConversion
    {
        public int AlternativeUnitID { get; }
        public string UnitName { get; }
        public int ConversionFactor { get; }

        public clsProductUnitConversion (int alternativeUnitID, string unitName, int conversionFactor)
        {
            AlternativeUnitID = alternativeUnitID;
            UnitName = unitName;
            ConversionFactor = conversionFactor;
        }

        public static List<clsProductUnitConversion> ConvertAlternativeUnitsTableToList(DataTable alternativeUnits)
        {
            List<clsProductUnitConversion> unitConversions = new List<clsProductUnitConversion>();

            if (alternativeUnits is null)
            {
                return unitConversions;
            }

            foreach (DataRow row in alternativeUnits.Rows)
            {
                unitConversions.Add(
                    new clsProductUnitConversion(
                        (int)row["AlternativeUnitID"],
                        (string)row["UnitName"],
                        (int)row["ConversionFactor"]
                        )
                    );
            }

            return unitConversions;
        }

        public static DataTable ConvertAlternativeUnitsListToTable(List<clsProductUnitConversion> alternativeUnits)
        {
            DataTable unitConversions = new DataTable();
            unitConversions.Columns.Add("AlternativeUnitID");
            unitConversions.Columns.Add("ConversionFactor");

            // هذا يعني أنه لا توجد وحدات بديلة فبالتالي نرجع جدول فارغ ليتم حذف الوحدات البديلة في قاعدة البيانات إن وجدت
            if (alternativeUnits is null)
            {
                return unitConversions;
            }

            foreach (clsProductUnitConversion unitConversion in alternativeUnits)
            {
                unitConversions.Rows.Add(unitConversion.AlternativeUnitID, unitConversion.ConversionFactor);
            }

            return unitConversions;
        }

    }
}
