using System;
using BusinessLogic.Employees;

namespace BusinessLogic.Reports
{
    public abstract class clsReport
    {
        public string ReportName { get; set; }
        public clsEmployee IssuedEmployeeName => clsEmployeeService.Find(1);
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime IssuedDate => DateTime.Now;
        public int IssuedYear => DateTime.Now.Year;
    }
}
