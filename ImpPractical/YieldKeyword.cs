using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    /*  "Yield" keyword helps to do custom stateful iteration over the collection.
          Custom iteration
          stateful iteration
          1. Custom iteration without using temp collection.
          2. Stateful Iteration 
    */
    class YieldKeyword
    {
        static List<int> myList = new List<int>();
        static void FillVaues()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
        }
        static void Main1(string[] args)
        {
            FillVaues();
            //foreach(int i in myList)  // direct list showing as it is
            //foreach (int i in Filter())
            //foreach (int i in FilterWithYield())
            foreach (int i in RunningTotalUsingYield())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        //Using IEnumerable<int> it as stateless iteration
        static IEnumerable<int> RunningTotalUsingYield()
        {
            int runningTotal = 0;
            foreach(int i in myList)
            {
                runningTotal += i;
                yield return (runningTotal);
            }
        }
        static IEnumerable<int> Filter()//greater than 3 filter function
        {
            List<int> temp = new List<int>();
            foreach (int i in myList)
            {
                if (i > 3)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }//Filtering without a temp collection.
        static IEnumerable<int> FilterWithYield()//greater than 3 filter function
        {
            foreach (int i in myList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }
        }
    }
}
