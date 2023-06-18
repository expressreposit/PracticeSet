using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class OperatorOverloading
    {
        static void Main1(string[] args)
        {
            OperatorClass obj1 = new OperatorClass();
            obj1.num1 = 10;
            obj1.str1 = "Amit";

            OperatorClass obj2 = new OperatorClass();
            obj2.num1 = 20;
            obj2.str1 = "Khobragade";

            OperatorClass obj3 = new OperatorClass();
            obj3 = obj1 + obj2;
            Console.WriteLine("The Operator of object : \n intobj: {0} \n strobj: {1} \n",obj3.num1.ToString(),obj3.str1);
            Console.ReadLine();
        }

        //static void Add(int num1, int num2)
        //{

        //}
        //static void Add(int num1, int num2, int num3)
        //{

        //}
    }
    class OperatorClass
    {
        public int num1 = 0;
        public string str1 = "";

        public static OperatorClass operator +(OperatorClass obj1, OperatorClass obj2)
        {
            OperatorClass obj3 = new OperatorClass();
            obj3.num1 = obj1.num1 + obj2.num1;
            obj3.str1 = obj1.str1 + obj2.str1;
            return obj3;
        }
    }
}
