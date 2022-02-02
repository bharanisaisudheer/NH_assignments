using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_loop_by_using_array_to_print_4_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("enter a number");
                data[i] =Convert.ToInt32(Console.ReadLine());
            }
            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
       
    }
}
