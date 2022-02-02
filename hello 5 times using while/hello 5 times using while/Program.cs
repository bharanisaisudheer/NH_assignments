using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_5_times_using_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Hello");
                i++;
            }
            Console.ReadLine();
        }
    }
}
