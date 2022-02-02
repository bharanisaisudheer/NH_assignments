using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intialize_an_array_with_5_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[]{ 1, 2, 3, 4, 5 };
            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
