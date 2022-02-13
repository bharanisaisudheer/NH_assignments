using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15thdayproject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter("C:\\quiz\\score and name.txt");
            int score = 0, ans;
            String name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("hi {0}, welcome to quiz by sudheer", name);
            sr.WriteLine(name);
            Console.WriteLine("Q1.what is the colour of apple:");
            Console.WriteLine("1. yellow 2. green 3. red 4. blue");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("Q2.what is the colour of mango:");
            Console.WriteLine("1. yellow 2. green 3. red 4. blue");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("Q3.what is the colour of Grapes:");
            Console.WriteLine("1. yellow 2. green 3. red 4. both white and black");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;
            Console.WriteLine("Q4.what is the colour of Bananna:");
            Console.WriteLine("1. yellow 2. green 3. red 4. blue");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("Q5.what is the colour of orange:");
            Console.WriteLine("1. yellow 2. orange 3. red 4. blue");
            Console.WriteLine("enter your choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
           sr.WriteLine(score);
            sr.Close();
            Console.WriteLine("Admin can contact with you");
            Console.ReadLine();


        }
    }
}

