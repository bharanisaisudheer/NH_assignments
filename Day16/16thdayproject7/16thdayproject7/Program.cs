using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thdayproject7
{
    class maths
    {
        int n, r, sum = 0, temp;
        public void Readdata()
        {
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void palindrome()
        {
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            if (temp == sum)
            { 
                 Console.WriteLine("number is palindrome");
            }
            else
                Console.WriteLine("number is not palindrome");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            maths p = new maths();
            p.Readdata();
            p.palindrome();
            Console.ReadLine();
        }
    }
}
