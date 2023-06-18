using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class Constant_ReadOnly
    {
        // global declaration
        public const int cmTometer = 100; //constant variable name value cannot change once we declare;
        //public static readonly double PI = 3.1;
        public static readonly double PI;   //readonly is runtime
        static Constant_ReadOnly()
        {
            PI = 3.14;
        }
        static void Main1(string[] args)
        {
            //cmTometer = 101;
            //PI = 3.14;

            Console.WriteLine(cmTometer);
            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
}
