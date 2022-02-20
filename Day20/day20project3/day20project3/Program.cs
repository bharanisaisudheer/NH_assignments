using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Multiplication(out x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static void Multiplication(out int a)
        {
            a = 10;
            a *= a;
        }
    }
}
