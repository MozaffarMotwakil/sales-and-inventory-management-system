using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reports;

namespace BusinessLogic.Reports
{
    public class clsCategorySales
    {
        public string CategoryName { get; }
        public decimal SalesAmount { get; }

        public clsCategorySales(string name, decimal amount)
        {
            CategoryName = name;
            SalesAmount = amount;
        }

        public static List<clsCategorySales> GetTopCategorySalesForCurrentMonth()
        {
            DataTable dt = clsReportData.GetTopCategorySalesForCurrentMonth();
            List<clsCategorySales> list = new List<clsCategorySales>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new clsCategorySales(
                    row["CategoryName"].ToString(),
                    Convert.ToDecimal(row["TotalSales"])
                ));
            }

            return list;
        }
    }
}
