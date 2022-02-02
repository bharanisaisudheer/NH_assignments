using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_day_5th_project
{
    class customer
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<customer> customers = new List<customer>()
            {
               new customer() { id = 1, name ="pavan", salary = 6000},
               new customer() { id = 2, name = "naga", salary = 8000 },
               new customer() { id = 3, name = "venkata", salary = 4000 },
               new customer() { id = 4, name = "sai", salary = 2000},

            };

            //forloop

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].salary > 5000)
                {
                    Console.WriteLine(customers[i].name);
                }
            }
            //foreach loop

            foreach (var e in customers)
            {
                if (e.salary > 5000)
                {
                    Console.WriteLine(e.name);
                }
            }
            //lambda expression

            customers.Where(e => e.salary > 5000).ToList().ForEach(e => Console.WriteLine(e.name));

            //Linq query

            var result = from e in customers
                         where e.salary > 5000
                         select e.name;
            result.ToList().ForEach(e => Console.WriteLine(e));
            Console.ReadLine();
        }
    }
}


        
