using _10th_day_project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_day_project1
{
    class algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    class totalmaths : algebra
    {
            public int mul (int a, int b)
            {
                return (a * b);
            }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            totalmaths tm = new totalmaths();
            Console.WriteLine(tm.add(5,6));
            Console.WriteLine(tm.mul(5,6));
            Console.ReadLine();
        }
    }
}
