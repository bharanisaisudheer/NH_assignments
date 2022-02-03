using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_4
{
    class employee
    {
        public int id;
        public string name;
        public int salary;

        public employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }
        public employee(int id, string name, int salary)
        {
            this.id = id; 
            this.name = name;
            this.salary = salary;
        }
        public void Readdata()
        {
            Console.WriteLine("enter employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            
        }
        public void printdata()
        {
            Console.WriteLine($"id : {id}, name : {name}, salary : {salary},");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(2,"sai",200);
            emp.Readdata();
            emp.printdata();
            Console.ReadLine();

        }
    }
}
