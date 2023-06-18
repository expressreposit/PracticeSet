using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    class ElementAtOperators
    {
        static void Main1(string[] args)
        {
            int[] ElementNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //  ElementAt accept Index position checked in collection.
            //  ElementAt(21) error if index out of Range.
            int ElementAtResult = ElementNumbers.ElementAt(0);

            //  ElementAt accept Index position checked in collection.
            //  ElementAt(21) return 21 or 0 as default value.
            int ElementAtOrDefaultResult = ElementNumbers.ElementAtOrDefault(21);
            Console.WriteLine("ElementAt() Result = " + ElementAtResult);
            Console.WriteLine("ElementAtOrDefault() Result = " + ElementAtOrDefaultResult);
            Console.ReadLine();
        }
    }
}
/*
ElementAt And ElementAtOrDefault
 */