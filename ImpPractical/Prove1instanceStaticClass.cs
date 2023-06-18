using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class Prove1instanceStaticClass
    {
        static void Main1(string[] args)
        {
            MyClass.SomeMethod();
            MyClass.SomeMethod();
            MyClass.count++;
            Console.WriteLine(MyClass.count);
        }
    }

    public static class MyClass
    {
        public static int count=1;
        //  If only one instance of the object is created then this constructor should only once.
        static MyClass() { }

        //  public static class can not have public constructor
        //public MyClass(){}

        //  public static class can not have public  static constructor
        //public static MyClass(){}

        public static void SomeMethod() { count++; }
    }
}
