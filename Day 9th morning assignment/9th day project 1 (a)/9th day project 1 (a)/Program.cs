using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_1__a_
{
    class Mathoperations
    {
        private int input;


        public void ReadInput()
        {
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;

            }
            return fact;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Mathoperations obj = new Mathoperations();
                obj.ReadInput();
                Console.WriteLine(obj.Factorial());
                Console.ReadLine();
            }
        }

    }

  
}
