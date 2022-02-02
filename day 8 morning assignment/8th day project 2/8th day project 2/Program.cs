using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_day_project_2
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
               new Employee() { id = 1, name ="pavan",salary =10000},
               new Employee() { id = 2, name = "naga", salary = 6000 },
               new Employee() { id = 3, name = "venkata", salary = 2000 },
               new Employee() { id = 4, name = "sai", salary = 50000},
                   
            };

            //forloop
            
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].salary > 5000)
                {
                    Console.WriteLine(Employees[i].name);
                }
            }
            //foreach loop
            
            foreach (var e in Employees)
            {
                if (e.salary > 5000)
                {
                    Console.WriteLine(e.name);
                }
            }
            //lambda expression

            Employees.Where(e => e.salary > 5000).ToList().ForEach(e => Console.WriteLine(e.name));

            //Linq query
            
            var result = from e in Employees
                         where e.salary > 5000
                         select e.name;
            result.ToList().ForEach(e => Console.WriteLine(e));
            Console.ReadLine();
        }
    }
}
