using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class Interface_Implement_SameMethod    //yes using Explicit implementation
    {
        static void Main1(string[] args)
        {
            I1 objI1Class = new ImplementClass();
            I2 objI2Class = new ImplementClass();
            objI1Class.Method1();
            objI2Class.Method1();
            Console.ReadLine();
        }
    }
    interface I1 { void Method1(); }
    interface I2 { void Method1(); }

     class ImplementClass : I1, I2  // If class implement interface  method "public" access modifier not required bcz interface is always public.
    {
        public void Method1() { Console.WriteLine("I am Method1 from which interface ? "); }
        //public void I1.Method1() { Console.WriteLine("I am Method1 from which interface ? "); }   //  Error.
        void I1.Method1() { Console.WriteLine("I am Method1 from I1 interface "); }
        void I2.Method1() { Console.WriteLine("I am Method1 from I2 interface "); }
    }
}
