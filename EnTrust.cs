using System;
using System.Collections.Generic;
using System.Text;

namespace Study { 
    delegate int Converter(int x,int  y);
    class Entrust
    {
        static void Main(string []args)
        {
            Converter t = (x, y) => { return (x * y + 1); };
            int relsult = t(3,6);
            Console.WriteLine(relsult);
        }
    }
}
