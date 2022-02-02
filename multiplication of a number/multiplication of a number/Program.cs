using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i <= 10; i++)
            {
                Console.Write(input+"x"+i+"="+input*i);
            }
           
            Console.ReadLine();
        }
    }
}
