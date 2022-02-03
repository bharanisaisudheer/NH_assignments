using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_1_c_
{
     class Primeoprations
    {
        private int input;


        public void ReadInput()
        {
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public bool Isprime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input%i == 0)
                    count ++;   
            }
            if (count == 2)
                return true;
            else 
                return false;
            
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Primeoprations obj = new Primeoprations();
                obj.ReadInput();
                if (obj.Isprime())
                    Console.WriteLine("input is prime number");
                else
                    Console.WriteLine("input is not a prime number");
                Console.ReadLine();
            }
        }

    }


}
