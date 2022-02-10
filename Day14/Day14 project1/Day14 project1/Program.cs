using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project1
{
     sealed class police
    {
        public static int helpline = 100;
        public string getpersonalphno()
        {
            return "9398388479";
        }
    }
     class theif 
     {
        public string name()
        {
            return "sai";
        }
     }



    
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(police.helpline);

          
             police p = new police();
          
            Console.WriteLine(p.getpersonalphno());
            theif t = new theif();
            Console.WriteLine(t.name());
            Console.ReadLine();

        }
    }


}
