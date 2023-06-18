using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    class ElementOperators
    {
        static void Main1(string[] args)
        {
            int[] Firstnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int Firstresult = Firstnumbers.First(); //  return 1st element IF value present, throws an error if Empty element.
            //int result = numbers.First(x=>x%2==0);
            int FirstOrDefaultresult = Firstnumbers.FirstOrDefault();  //  return 1st element IF value present in collection, return 0 if int[] numbers {} Empty element default Value.

            Console.WriteLine("First() Result = " + Firstresult);
            Console.WriteLine("FirstOrDefault() Result = " + FirstOrDefaultresult);

            int[] Lastnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int Last = Lastnumbers.Last();  //  return Last element IF value present, throws an error if {} Empty element.
            int LastOrDefault = Lastnumbers.LastOrDefault();    //  return Last element IF value present in collection, return 0 {} Empty element default Value.

            Console.WriteLine("Last() Result = " + Last);
            Console.WriteLine("LastOrDefault() Result = " + LastOrDefault);
            Console.ReadLine();
        }
    }
}
/*
    First And FirstOrDefault
    Last And LastOrDefault
 */