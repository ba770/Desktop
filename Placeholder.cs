using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    class Rectangle
    {
        private double length;
        internal double width;
        internal double area;

        public void setThem()
        {
    
            length = 3.3;
            width = 2.3;
            area = length * width;
        }

        public void show()
        {
            Console.WriteLine("lengh:{0}",length);
            Console.WriteLine("width:{0}",width);
            Console.WriteLine("area:{0}", area);
        }
    }
}
