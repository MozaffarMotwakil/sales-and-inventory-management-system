using System.Data;

namespace DataAccess.Employees
{
    public static class clsEmployeeData
    {
        public static DataTable GetAllEmployeeNames()
        {
            return clsDataSettings.GetDataTable(
                "usp_Employees_GetAllEmployeeNames"
                );
        }
    }
}
