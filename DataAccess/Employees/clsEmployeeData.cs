using System.Data;

namespace DataAccess.Employees
{
    public static class clsEmployeeData
    {
        public static DataTable GetEmployeesList()
        {
            return clsDataSettings.GetDataTable(
                "usp_Employees_GetEmployeesList"
                );
        }
    }
}
