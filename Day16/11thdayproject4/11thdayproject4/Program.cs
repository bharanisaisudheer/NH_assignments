using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11thdayproject4
{
    class employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
        public int Id
        {
            get { return id; }
            set { Id = value; }
        }
        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Designation
        {
            set { designation = value; }

        }
        public int Salary
        {
            get
            {
                salary = (designation == "s") ? 3000 : 6000;
                return salary;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.Designation = "t";
            Console.WriteLine(e.Salary);
            
            Console.ReadLine();
        }
    }
}

