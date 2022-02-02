using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_sum_of_numbers_using_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[5];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("enter numbers");
                data [i] = Convert.ToInt32(Console.ReadLine());

            }
            for ( int i = 0; i < data.Length;i++)
            {
                sum = sum + data[i];
                Console.WriteLine("sum="+sum);
                
            }
            Console.ReadLine();
        }
    }
}
