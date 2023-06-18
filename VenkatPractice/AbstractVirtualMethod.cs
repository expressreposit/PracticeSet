using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class AbstractVirtualMethod
    {
        static void Main1(string[] args)
        {
            SomeClass SC = new SomeClass();
            SC.AbstractClassAMethod();
            SomeOtherClass SO = new SomeOtherClass();
            SO.AbstractClassAMethod();
            Console.ReadLine();
        }
    }
    public abstract class AbstractClassA
    {
        public virtual void AbstractClassAMethod()
        {
            Console.WriteLine("Default Implementation");
        }
    }
    public class SomeClass: AbstractClassA
    {
    }
    public class SomeOtherClass: AbstractClassA
    {
        public override void AbstractClassAMethod()
        {
            Console.WriteLine("New Implementation");
        }
    }
}
