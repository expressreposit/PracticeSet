using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class DeprecatedMethod
    {
        static void Main1(string[] args)
        {
            class1 o = new class1();
            //o.Method1();    //  Method1 is use before NewMethod1.
            o.NewMethod1(); //  NewMethod1 force to use developer.
        }
    }
    class class1
    {
        [Obsolete("Use NewMethod1",true)]   //  It force to use NewMethod1 and true is assign the error.
        public  void Method1()
        {
        }
        public  void NewMethod1()
        {
        }
    }
}
