using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13thdayproject10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(1);
            data.Enqueue(2);
            data.Enqueue(3);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}
