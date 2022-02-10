using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thdayproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 96, i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine("prime");
            else
            Console.WriteLine("not prime");
            Console.ReadLine();
        }
    }
}
