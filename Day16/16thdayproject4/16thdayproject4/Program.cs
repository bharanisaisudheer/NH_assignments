using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thdayproject4
{
    class multiplication
    {
        public int n;
        public void Readinput()
        {
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void printdata()
        {
            for ( int i = 1; i<=10; i++)
            {
                Console.WriteLine($"{n}*{i}={i*n}");
            }
        }
        
           

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            multiplication m = new multiplication();
            m.Readinput();
            m.printdata();
            Console.ReadLine();
        }
    }
}
