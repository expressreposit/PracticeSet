using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSets
{
    /*
            What do we need of private constructor in C#?
            1.A private constructor means that the class can't be instantiated from outside the class.
            2.Private constructors can be useful when using a factory pattern commen function use in application.
            3.You cannot add public constructor without parameters.i.e.
    */
    class constructors
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------constructor");
            //classA _a = new classA();     could not create instance bcz of private ctor
            classA a = new classA(2);   //public ctor with parameterized accessible
            a.AccessMethod();
            // A.getAInstance();   //static method accessible only in static method without creating instance
            classA.AccessStaticMethod();
            Console.ReadLine();
        }
    }
    class classA
    {
        private classA()
        {
            Console.WriteLine("ClassA private::constructor()");
        }
        //public classA(){ }
        /*
            8.If you want to create object of class(ClassA) even if we have private constructor(ClassA)
            then we need to add a public parameterise constructor along with private constructor.i.e.
        */
        public classA(int a)
        {
            Console.WriteLine("classA with params:: constructor");
        }
        public void AccessMethod()
        {
            Console.WriteLine("Access Method using create instance from parameterized constructor");
        }
        public static void AccessStaticMethod()
        {
            Console.WriteLine("Access static Method using Class Name dot Method Name.");
        }
    }
}
