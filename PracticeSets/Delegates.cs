using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    public delegate int AddByDeligate(int var1, int var2);  //step  1 Declare
    class Delegates
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------Delegate");
            AddByDeligate byDeligate = new AddByDeligate(Delegates.Add);
            Console.WriteLine("Please enter value");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            //Here method Delegates.Add call 
            int Result = byDeligate(num1, num2);
            Console.WriteLine("Result: " + Result);
            Console.ReadLine();
        }
        public static int Add(int a, int b)//step  2 create
        {
            return a + b;
        }
        //  step 3 point    in main()
    }
}
/*
        A Delegate is an object which holds the references to a method within delegate object.
        A Delegate is a type-safe object.
        A Delegate is invoking to methods in asynchronously manner. 
        A Delegate encapsulates a static method or instance methods. 
        A Delegate can be with parameters or without parameters. 
*/
