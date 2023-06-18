using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class CoalescingOperator
    {
        static void Main1(string[] args)
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "str4";

            //  coalescing operator returns the first non-null value from a chain.
            string final = str1 ?? str2 ?? str3 ?? str4;
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}
