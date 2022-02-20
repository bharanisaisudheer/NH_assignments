using System;

using System.Xml;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace day19project2

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

                foreach (XmlNode cnode in node.ChildNodes)

                {

                    if (cnode.Name == "Name")

                    {

                        Console.WriteLine(cnode.InnerText);

                    }

                }

            }

            Console.ReadLine();

        }

    }

}