using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15dayproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                StreamWriter sr = new StreamWriter("C:\\yuvi\\yuvi1", true);

                sr.WriteLine("sai");

                sr.WriteLine("yuvi");

                sr.Close();

                Console.WriteLine("done");

                Console.ReadLine();



            }




        }
    }
}
