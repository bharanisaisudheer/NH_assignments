using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for mathematics
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class mathematics : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int  Factorial(int n)
        {
            int  fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }
        [WebMethod]
        public int add(int a, int b)
        {
            return a + b;   
        }
        [WebMethod]
        public int  mul(int a, int b)
        {
            return a * b;
        }
        [WebMethod]
        public int div(int a, int b)
        {
            return a / b;
        }




    }
}
