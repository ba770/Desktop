﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study
{
    class Linq
    {
        static void Main(string[] args)
        {
            string[] names = { "Hartono, Tommy", "Adams, Terry",
                     "Andersen, Henriette Thaulow",
                     "Hedlund, Magnus，Fuckit,shit,asdlfjladsjfljas","Ito, Shu" };

            string firstLongName =  names.FirstOrDefault(name => name.Length > 2000);

            Console.WriteLine("The first long name is '{0}'.", firstLongName);

            string firstVeryLongName = names.FirstOrDefault(name => name.Length > 30);

            Console.WriteLine(
        "There is {0} name longer than 30 characters.",
        string.IsNullOrEmpty(firstVeryLongName) ? "not a" : "a");
        }

/*
 This code produces the following output:

 The first long name is 'Andersen, Henriette Thaulow'.
 There is not a name longer than 30 characters.
*/
    }
}
