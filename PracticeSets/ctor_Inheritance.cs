using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    class ctor_Inheritance
    {
        static void Main1(string[] args)
        {
            ctor_Inheritance_B inheritance_B = new ctor_Inheritance_B();//both ctor call if we inherit
            //If child constructor is missing then parent constructor is called.
            //If parent constructor is missing the child constructor is called.
            ctor_Inheritance_D _Inheritance_D = new ctor_Inheritance_D("param Amit");//return base class ctor and derive class parameterized ctor call.

            Console.ReadLine();
        }
    }
    class ctor_Inheritance_A
    {
        public ctor_Inheritance_A()
        {
            Console.WriteLine("ClassA::Constructor()");
        }
    }
    class ctor_Inheritance_B: ctor_Inheritance_A
    {
        public ctor_Inheritance_B()
        {
            Console.WriteLine("ClassB::Constructor()");
        }
    }
    /*
            If child constructor is missing then parent constructor is called.
            If parent constructor is missing then child constructor is called.
    */
    class ctor_Inheritance_C
    {
        public ctor_Inheritance_C()
        {
            Console.WriteLine("ClassC::Constructor()");
        }
        public ctor_Inheritance_C(string name)
        {
            Console.WriteLine("ClassC::Constructor() with params name: " + name);
        }
    }
    class ctor_Inheritance_D : ctor_Inheritance_C
    {
        public ctor_Inheritance_D()
        {
            Console.WriteLine("ClassD::Constructor()");
        }
        public ctor_Inheritance_D(string name)
        {
            Console.WriteLine("ClassD::Constructor()with params name: " + name);
        }
    }
}
