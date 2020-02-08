using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study
{
    class Test2
    {
        static void Main(string[] args)
        {
            HashSet<int> test = new HashSet<int>();
            test.Add(22);
            Console.WriteLine(test.Any());
        }
    }
}
