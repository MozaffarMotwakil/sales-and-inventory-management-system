using System.Collections.Generic;
using System.Data;

namespace BusinessLogic.Products
{
    public class clsProductUnitConversion
    {
        public int AlternativeUnitID { get; }
        public string UnitName { get; }
        public int ConversionFactor { get; }
        public decimal SellingPrice { get; }
        public string Barcode { get; }

        public clsProductUnitConversion (int alternativeUnitID, string unitName, int conversionFactor, decimal sellingPrice, string barcode)
        {
            AlternativeUnitID = alternativeUnitID;
            UnitName = unitName;
            ConversionFactor = conversionFactor;
            SellingPrice = sellingPrice;
            Barcode = barcode;
        }

        public static List<clsProductUnitConversion> ConvertAlternativeUnitsTableToList(DataTable alternativeUnits)
        {
            List<clsProductUnitConversion> unitConversions = new List<clsProductUnitConversion>();

            // To prevent NullReferenceException if the list is null.
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
                        (int)row["ConversionFactor"],
                        (decimal)row["SellingPrice"],
                        (string)row["Barcode"]
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
            unitConversions.Columns.Add("SellingPrice");
            unitConversions.Columns.Add("Barcode");

            // To prevent NullReferenceException if the list is null.
            if (alternativeUnits is null)
            {
                return unitConversions;
            }

            foreach (clsProductUnitConversion unitConversion in alternativeUnits)
            {
                unitConversions.Rows.Add(
                    unitConversion.AlternativeUnitID,
                    unitConversion.ConversionFactor,
                    unitConversion.SellingPrice,
                    unitConversion.Barcode
                    );
            }

            return unitConversions;
        }

    }
}
