using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13thdayproject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'p', 'a', 'v', 'a', 'n' };
            names[1] = new char[] { 'v', 'e', 'n', 'k', 'a','t','a' };
            names[2] = new char[] { 's', 'a', 'i','s','u','d','h','e','e','r'};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
           


        }
        
    }
}
