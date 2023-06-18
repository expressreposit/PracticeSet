using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LINQ
{
    class SingleOrDefaultElement
    {
        static void Main1(string[] args)
        {
            int[] number = { 1 };

            //  return single given value,
            //  { } error if empty expect single element.
            //  {1,2} error throws bcz sequence containce more than single element.
            // only single element requred.
            int SingleResult = number.Single();
            Console.WriteLine("Single Result = " + SingleResult);

            // doesn't allow more than one value into collection.
            //  {} return 0 as default value.
            int SingleOrDefaultResult = number.SingleOrDefault();
            Console.WriteLine("SingleOrDefaultResult = " + SingleOrDefaultResult);

            int[] DefaultNumber = { 1,2,3 };
            //  return all present element as integer value.
            //  {} return 0 Default or Empty Element.
            var DefaultEmptyResult = DefaultNumber.DefaultIfEmpty(10);  // return 10 if pass value parameter, If {1,2,3} present then those value 1,2,3 will be return.
            foreach (int i in DefaultEmptyResult)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
/*
Single And SingleOrDefault
DefaultIfEmpty
 */