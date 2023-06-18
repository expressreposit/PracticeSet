using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    delegate int MulticastDelegateName(int num1, int num2);
    class MulticastDelegate
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------Multicast Delegate");
            MulticastDelegateName multicastDelegateName = new MulticastDelegateName(MulticastDelegate.Add);
            Console.WriteLine("Please enter numbers!");

            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());
            int AddResult = multicastDelegateName(num3, num4);
            Console.WriteLine("AddResult: " + AddResult);

            multicastDelegateName += new MulticastDelegateName(MulticastDelegate.Sub);
            int SubResult = multicastDelegateName(num3, num4);
            Console.WriteLine("Sub Result: " + SubResult);
            Console.ReadLine();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
/*
    The multicast delegate is hold the references of more than one methods within the delegate object using the (+=) operator.
    1.    Delegate is added using the (+=) operator. 
    2.    Delegate is removed using the (-=) operator. 
*/
