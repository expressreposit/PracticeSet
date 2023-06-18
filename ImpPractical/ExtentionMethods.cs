using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    //  Extention Methods helps to add new methods to existing type without modifying the original code, inheriting or aggegating.
    class ExtentionsMethods
    {
        static void Main1(string[] args)
        {
            Console.ReadLine();
        }
    }

    public static class ExtenstionMethod
    {
        public static int Add(this string obj)
        {
            return Int32.Parse(obj);
        }
    }
}
