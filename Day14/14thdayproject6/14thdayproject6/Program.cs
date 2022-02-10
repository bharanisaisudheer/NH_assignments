using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thdayproject6
{
    internal class Program
    {
        class student
        {
            public string name { get; set; }    
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "sudheer";
            Console.WriteLine(s.name);
            Console.ReadLine();
        }
    }
}
