using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class Generic_GenericCollection
    {
        static void Main1(string[] args)
        {
            //  generic with int data type
            checkValues<int> objInt = new checkValues<int>();
            objInt.compare(12, 32);
            Console.WriteLine(objInt.compare(12, 32));//compare values

            //  generic with string data type
            checkValues<string> objString = new checkValues<string>();
            Console.WriteLine(objString.compare("Amit", "Amit"));
            Console.ReadLine();
        }
    }
    class checkValues<T>
    {
        public bool compare(T i, T j)
        {
            if (i.Equals(j))
                return true;
            else
                return false;
        }
    }
}
