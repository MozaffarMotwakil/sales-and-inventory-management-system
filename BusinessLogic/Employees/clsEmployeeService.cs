using System.Data;
using System.Linq;
using DataAccess.Employees;

namespace BusinessLogic.Employees
{
    public class clsEmployeeService
    {
        public static object[] GetAllEmployeeName()
        {
            return clsEmployeeData.GetAllEmployeeNames()
                .Rows
                .Cast<DataRow>()
                .Select(row => row[0])
                .ToArray();
        }
    }
}
