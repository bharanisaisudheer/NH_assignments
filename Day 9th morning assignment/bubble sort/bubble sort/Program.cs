using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 20, 40, 50, 30, 60,  };
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);

            }
        }
    }
}
