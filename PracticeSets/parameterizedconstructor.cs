using System;
using System.Collections.Generic;
using System.Text;
namespace PracticeSets
{
    class parameterizedconstructor
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------Parameteterized constructor");
            A.getAInstance();   //static method accessible only in static method(static void Main()) without creating instance
            parameterizedconstructor_B _B = new parameterizedconstructor_B("amit");//call base class ctor from derive calss ctor
            parameterizedconstructor_A _A = new parameterizedconstructor_A("base amit");//Direct base class call param ctor
            Console.WriteLine(A.getAInstance());//A static method can call the private constructor to create a new instance of that class.
            Console.ReadLine();
        }
    }
    //How to call base class parameterized constructor first in c#?
    class parameterizedconstructor_A
    {
        public parameterizedconstructor_A()
        {
            Console.WriteLine("Bbase Class With Public:: Constructor");
        }
        public parameterizedconstructor_A(string name)
        {
            Console.WriteLine("Base Class With Parameterized :: Constructor " + name);
        }
    }
    class parameterizedconstructor_B : parameterizedconstructor_A
    {
        public parameterizedconstructor_B()
        {
            Console.WriteLine("Derive Class :: Constructor");
        }
        public parameterizedconstructor_B(string name) : base(name)
        {
            Console.WriteLine("Derive Class With Parameterized :: Constructor " + name);
        }
    }
}
