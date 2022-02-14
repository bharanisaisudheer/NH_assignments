using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudheerlibrary
{

    public class mathematics
    {
        //read input from user
        int n;
        public void Readdata()
        {
            Console.WriteLine("enter any number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        //print data
        int fact = 1;
        public void printdata()
        {
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;


            }
            Console.WriteLine(fact);

        }
    }
}
