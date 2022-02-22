using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dataacesslayerlibrary;

namespace Businesslogiclibrary
{
    public class EmployeeBll
    {
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            var result = EmployeeDAL.AddEmployee(empid, empname, empsalary, empage);
            return result;
        }
        public static List<String> GetEmployeesById(int id)
        {
            var result = EmployeeDAL.GetEmployeesById(id);
            return result;
        }
        public static List<String> GetEmployeesByName(string name)
        {
            var result = EmployeeDAL.GetEmployeesByName(name);
            return result;  

        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}
