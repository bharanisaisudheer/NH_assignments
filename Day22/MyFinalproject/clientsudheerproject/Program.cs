using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businesslogiclibrary;

namespace clientsudheerproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            String choice;

            do
            {
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("1. Add Employee:");
                Console.WriteLine("2. Search Employee by id:");
                Console.WriteLine("3. Search Employee by name:");
                Console.WriteLine("4. Display All Employees:");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeebyId();
                        break;
                    case 3:
                        SearchEmployeebyName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("Do you want to continue(Y/N):");
                choice = Console.ReadLine();

            }
            while (choice.Equals("y"));
        }
        public static void AddEmployee()
        {
            int id, salary, age;
            String name;
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            //call Bll Method
            var result = EmployeeBll.AddEmployee(id, name, salary, age);    
            if(result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("some error occured");


        }
        public static void SearchEmployeebyId()
        {
            int id;
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBll.GetEmployeesById(id);
            if(result.Count==0)
                Console.WriteLine("no records exists with this id");
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }
        public static void SearchEmployeebyName()
        {
            String name;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            var result = EmployeeBll.GetEmployeesByName(name);
            result.ForEach(p => Console.WriteLine(p));



        }
        public static void DisplayAllEmployees()
        {
            var result = EmployeeBll.GetAllEmployees();
            foreach(var res in result)
            {
                Console.WriteLine(res);
            }

        }

    }
}
