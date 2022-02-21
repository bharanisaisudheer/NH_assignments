using _21dayproject1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21dayproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathematicsSoapClient m = new mathematicsSoapClient();
            Console.WriteLine(m.Factorial(5));
            Console.WriteLine(m.add(5,6));
            Console.WriteLine(m.mul(5,6));
            Console.WriteLine(m.div(5,6));
            Console.ReadLine();
        }
    }
}
