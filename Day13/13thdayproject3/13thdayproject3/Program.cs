using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13thdayproject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2, 3 }, { 4, 5, 4 }, { 6, 4, 8 } };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    if (i == j)
                        sum = sum + data[i, j]; 
                         
                }
                Console.Write("\n");
                

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
