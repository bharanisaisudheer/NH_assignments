﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_day_project_2_c_
{
    class Mathmultiplication
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
        public int mulnumbers()
        {
            return a * b;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Mathmultiplication mul = new Mathmultiplication();
                mul.ReadInput();
                Console.WriteLine(mul.mulnumbers()) ;
                Console.ReadLine();
            }
        }

    }


}
