using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_day_4th_project
{
    class Department
    {
        public int id;
        public string name;
        public int departmentcount;


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Department> data = new List<Department>()
            {
               new Department() { id = 1, name ="pavan",departmentcount =20},
               new Department() { id = 2, name = "naga", departmentcount = 55},
               new Department() { id = 3, name = "venkata", departmentcount = 50},
               
            };

            // forloop
            
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].departmentcount > 50)
                {
                    Console.WriteLine($"id={data[i].id}, brand={data[i].name}");
                }
            }
            // foreach loop
            
            foreach (var d in data)
            {
                if (d.departmentcount > 50)
                {
                    Console.WriteLine($"id={d.id}, brand={d.name}");
                }
            }
            //lambda expression
            
            data.Where(d => d.departmentcount > 50).ToList().ForEach(d => Console.WriteLine($"id={d.id}, brand={d.name}"));
            
            //linq query
            var result = from d in data
                         where d.departmentcount > 50
                         select d.id + "--" + d.name;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
