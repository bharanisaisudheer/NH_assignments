using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_day_project1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 42, 52, 64, 89, 77, 65, 33, 28 };
            //even number using loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            //for each loop
            foreach (var d in data)
            {
                if (d%2==0)
                    Console.WriteLine(d);
            }
            //lambda Expression
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));
            //linq query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
