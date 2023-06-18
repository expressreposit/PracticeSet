using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class privateConstructor
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(classA.strData());
            Console.ReadLine();
        }
    }

    // use for utility and common function to use in application.
    class classA
    {
        private classA()
        {
        }
        public static string strData()
        {
            string str = "hello commen utility I'm coming from private constructor";
            return str;
        }
    }
}
