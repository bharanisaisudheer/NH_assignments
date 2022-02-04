using _10th_day_project2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10th_day_project2
{
    class sudheer
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    class totalmaths : sudheer
    {
        public int mul(int a, int b)
        {
            return (a * b);
        }


    }
    class saisubjects : totalmaths
    {
        public string sai()
        {
            return "yuvi";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            saisubjects tm = new saisubjects();
            Console.WriteLine(tm.add(5,6));
            Console.WriteLine(tm.sai());
            
                Console.ReadLine();
        }
    }
}

