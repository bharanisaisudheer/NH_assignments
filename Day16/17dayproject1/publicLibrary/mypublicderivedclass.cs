using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sudheerLibrary;

namespace publicLibrary
{
    public class mypublicderivedclass : mybaseclass
    {
        public void mypublicderivedclassMethod()
        {
            a = 5;
            b = 6;
            c = 7;
            d = 8;
            e = 9;
        }

    }
    public class mypubliclibraryotherclass
    {
        public void mypubliclibraryotherclassMethod()
        {
            mybaseclass m = new mybaseclass();
            m.a = 5;
            m.b = 6;
            m.c = 7;
            m.d = 8;
            m.e = 9;
        }

    }

}
