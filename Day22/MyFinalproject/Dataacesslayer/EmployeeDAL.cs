using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataacesslayerlibrary
{
    public static class EmployeeDAL
    {
         static string filepath = "C:\\Employeedata\\employee.txt";

        

        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            try
            {
                string textContent = string.Concat(empid, ",", empname, ",", empsalary, ",", empage, ",");
                File.AppendAllText(filepath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
        public static List<String> GetEmployeesById(int id)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<string> employeesFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    employeesFound.Add(employee);
                    break;
                }
            }
            return employeesFound;
        }
        public static List<String> GetEmployeesByName(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);

            List<string> employeesFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {

                    employeesFound.Add(employee);
                    break;
                }
            }
            return employeesFound;
        }
    
       public static string[] GetAllEmployees()
       {
        var allEmployees = File.ReadAllLines(filepath);
        return allEmployees;
       }





    }

    
}

