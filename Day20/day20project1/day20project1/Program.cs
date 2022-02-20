using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20project1
{
    public delegate void MyCaller(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc += Div;

            //10,20
            mc(10, 20);

            //20,30
            mc(20, 30);

            //80,90
            mc(80, 90);

            Console.ReadLine();
        }
    }
}