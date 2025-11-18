using System.Data;
using System.Linq;
using DataAccess.Employees;

namespace BusinessLogic.Employees
{
    public class clsEmployeeService
    {
        public static DataTable GetEmployeesList()
        {
            return clsEmployeeData.GetEmployeesList();
        }

        public static object[] GetEmployeeNames()
        {
            return clsEmployeeData.GetEmployeesList()
                .Rows
                .Cast<DataRow>()
                .Select(row => row["EmployeeName"])
                .ToArray();
        }

        public static clsEmployee Find(int employeeID)
        {
            return new clsEmployee(3);
        }

    }
}
