using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10th_day_project_4
{
    class english 
    {
                   public void printsai()
                   {
                       Console.WriteLine("sai");
                   }

                   public void printsudheer()
                   {
                          Console.WriteLine("sudheer");

                   }
                   public  void printpavan()
                   {
                         Console.WriteLine("pavan");

                   }

     }
     class telug : english
     {
        public new void printpavan()
       {
        Console.WriteLine("yuvi");

        }

     }
      
    internal class Program
    {
        

        static void Main(string[] args)
        {
            telug t1 = new telug();
            t1.printsudheer();
            

            
            
            Console.ReadLine();
        }
    }
}
