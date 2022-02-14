using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sudheerLibrary;
using publicLibrary;

namespace client_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mathematics.factorial(5));
            Console.WriteLine(mathematics.Add(5,6));
            Console.WriteLine(mathematics.mul(5,6));
            
            Console.WriteLine(physics.Finalvelocity(5,5,5));
            
            Console.ReadLine();
        }
    }
}
