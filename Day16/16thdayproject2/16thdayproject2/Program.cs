using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thdayproject2
{
    class factorial
    {
        //read input from user
        int n;
        public void Readdata()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        //print data
        int fact = 1;
        public  void   printdata()
        {
            for (int i = 1; i<=n; i++)
            {
                fact = fact * i;
               
                
            }
             Console.WriteLine(fact);
            
            

        }
         
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial f = new factorial();
            f.Readdata();
            f.printdata();
            Console.ReadLine();

        }
    }
}
