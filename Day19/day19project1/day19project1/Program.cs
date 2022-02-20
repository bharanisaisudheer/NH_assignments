using System;

using System.Xml;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace day19project1

{

    internal class Program

    {

        static void Main(string[] args)

        {

            XmlDocument doc = new XmlDocument();

            doc.Load("C:\\files\\employees.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/employees/employee"); 

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)

            {

                string text = node.InnerText; //or loop through its children as well 

                Console.WriteLine(text);

            }

            Console.ReadLine();

        }

    }

}