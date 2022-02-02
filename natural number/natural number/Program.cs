using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine(" Enter any numbers:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum = sum + i;

                Console.WriteLine("sum="+sum);
                
                
            }
            Console.ReadLine();
            
        }
    }

         
}
