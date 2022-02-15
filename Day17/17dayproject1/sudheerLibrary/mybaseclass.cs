using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudheerLibrary
{
    public class mybaseclass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void mybaseMethod()
        {
            a = 5;
            b = 6;
            c = 7;
            d = 8;
            e = 9;
        }
           
    }
    public class myDerivedclass :mybaseclass
    {
        public void myderivedclassMethod()
        {
            
            a = 5;
            b = 6;
            c = 7;
            d = 8;
            e = 9;
            

        }
        public void otherclassMethod()
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
