using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_2__d_
{
    class Mathdivision
    {
        private int a;
        private int b;


        public void ReadInput()
        {
            Console.WriteLine("enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b number");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int divnumbers()
        {
            return a % b;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Mathdivision mt = new Mathdivision();
                mt.ReadInput();
                Console.WriteLine(mt.divnumbers());
                Console.ReadLine();
            }
        }

    }


}
