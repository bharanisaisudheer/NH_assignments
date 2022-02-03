using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public string company;

        public void Readdata()
        {
            Console.WriteLine("enter employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            company = "NB";
        }
        public void printdata()
        {
            Console.WriteLine($"id : {id}, name : {name}, salary : {salary}, company : {company}");
        }
        


        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Readdata();
                emp.printdata();
                Console.ReadLine();
                
            }
        }

    }


}

