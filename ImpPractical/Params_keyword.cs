using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class Params_keyword
    {
        static void Main1(string[] args)
        {
            int y = Add(12, 18,43,54,22,55,21);
            Console.WriteLine("The addition of number is: " + y);
            Console.ReadLine();
        }
        //public static int Add(int num1, int num2)
        public static int Add(params int[] ListNumbers)
        {
            //return num1 + num2;
            int total = 0;
            foreach( int i in ListNumbers)
            {
                total = i + total;
            }
            return total;
        }

    }
}
