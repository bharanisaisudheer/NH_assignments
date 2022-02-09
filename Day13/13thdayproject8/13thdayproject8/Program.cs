using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13thdayproject8
{
    internal class Program
    {
       
         static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i < num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
