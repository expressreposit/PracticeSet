using System;

namespace PracticeSets
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------Generic Delegate");
            // int is a input parameter and double is output parameter
            Func<int, double> piR2r = r => 3.12 * r * r;
            Console.Write(piR2r(4));

            //return void when you need to input parameter and no need to return output that means return void.
            Action<string> ActionObject = x => Console.WriteLine(x);
            ActionObject("This is action delegate");

            //String is input but output is return is true or false
            Predicate<string> checkCondTF = x => x.Length > 10;
            Console.WriteLine(checkCondTF("Amit khobragade"));

            Console.ReadLine();
        }
    }
    //5.When you want to prevent the users of your class from instantiating the class directly.
    //6.A static method can call the private constructor to create a new instance of that class.
    //7.In this case, you have a static method defined inside the class that internally calls the private constructor.
    class A
    {
        private A() { }
        private static A theA = new A();
        public static A getAInstance()//A static method can call the private constructor to create a new instance of that class.
        {
            return theA;
        }
    }
}
