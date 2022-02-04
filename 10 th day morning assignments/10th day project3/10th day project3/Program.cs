using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_day_project3
{
    class sai
    {
        public int add (int a, int b)
        {
            return a + b;
        }
        public int add (int a, int b, int c)
        {
            return a + b + c;   
        }
        public int add (int a, int b, int c, int d)
        {
            return a+b + c + d; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sai pn = new sai();
            Console.WriteLine(pn.add(5,6));
            Console.ReadLine();
        }
    }
}
