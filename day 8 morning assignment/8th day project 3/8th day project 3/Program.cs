using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project3
{

   
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Product> data = new List<Product>()
            {
               new Product() { id = 1, name ="Pavan",price =200,brand="mi"},
                new Product() { id = 2, name = "naga", price = 600,brand="realme" },
                 new Product() { id = 3, name = "venkata", price = 300,brand="lava"},
                  
            };

            //by using forloop
           
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].price > 500)
                {
                    Console.WriteLine($"name={data[i].name}, brand={data[i].brand}");
                }
            }
            //by using foreach loop
            
            foreach (var d in data)
            {
                if (d.price > 500)
                {
                    Console.WriteLine($"name={d.name}, brand={d.brand}");
                }
            }
            //by using lambda expression
            
            data.Where(d => d.price > 500).ToList().ForEach(d => Console.WriteLine($"name={d.name}, brand={d.brand}"));
            //using Linq
            
            var result = from d in data
                         where d.price > 500
                         select d.name + "--" + d.brand;

            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }

    }

}