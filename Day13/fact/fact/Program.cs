using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Factorial
    {
        public int display(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * display(n - 1);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int value = 6;
                
                int ret;
                Factorial fact = new Factorial();
                ret = fact.display(value);
                Console.WriteLine("Value is : {0}", ret);
                Console.ReadLine();
              
            }
        }
    }
}
