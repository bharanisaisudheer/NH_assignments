using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudheerlibrary
{
    public class physics
    {
        
        public int u;
        public int a;
        public int t;
        public void Readdata()
        {
            Console.WriteLine("enter u value");
            u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter t value");
            t = Convert.ToInt32(Console.ReadLine());

        }
        public int Finalvelocity()
        {
            return u + a * t;
        }
    }
}
