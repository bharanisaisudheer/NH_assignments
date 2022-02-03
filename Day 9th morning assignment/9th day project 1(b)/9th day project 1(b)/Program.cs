using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_1_b_
{
    class Mathoperations
    {
        private int input;


        public void ReadInput()
        {
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public void  printfactors()
        {
            
            for (int i = 1; i <= input; i++)
            {
                if (input%i == 0)
                    Console.WriteLine(i);

            }
            
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Mathoperations obj = new Mathoperations();
                obj.ReadInput();
                obj.printfactors();
                Console.ReadLine();
            }
        }

    }


}