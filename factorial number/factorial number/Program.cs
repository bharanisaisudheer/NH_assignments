using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, fact = 1;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            { 
                    fact = fact * i;
                Console.WriteLine("fact="+fact);
                
            }
            Console.ReadLine();


        }
        
        
    }
}
