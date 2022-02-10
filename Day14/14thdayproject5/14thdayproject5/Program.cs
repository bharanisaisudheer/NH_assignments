using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thdayproject5
{
    class student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                student s = new student();
                s.Name = "sai";
                Console.WriteLine(s.Name);
                Console.ReadLine();
            
        }
       
    }
}
