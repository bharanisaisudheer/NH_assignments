using System;
using Sudheerlibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thdayproject5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            physics p = new physics();
            p.Readdata();
            Console.WriteLine(p.Finalvelocity());
            


           mathematics m = new mathematics();
           m.Readdata();

            m.printdata();
            
            chemistry c = new chemistry();
            Console.WriteLine(c.Getbenzene());
            Console.WriteLine(c.Getwater());
            Console.ReadLine();
        }
    }
}
