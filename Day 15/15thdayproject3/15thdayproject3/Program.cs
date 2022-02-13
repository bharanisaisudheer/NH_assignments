using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15thdayproject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("c:\\yuvi\\yuvi1");
            string data = sr.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
                
            }
            Console.WriteLine("fileread");
            Console.ReadLine();
        }
    }
}
