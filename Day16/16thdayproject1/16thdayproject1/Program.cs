using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thdayproject1
{
    //**************************************************************//
    //***************************************************************//
    
    class message
    {

        public static string name()
        {
            return  "Hello";
                
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( message.name());
            
           
            Console.ReadLine();
        }
    }
}
