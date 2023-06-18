using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class parentChildCtorFireFirst
    {
        static void Main1(string[] args)
        {
            // Both constructor fire, but Parent constructor fire first
            ClassChild objChild = new ClassChild();
            //ClassParent objParent = new ClassParent();
            Console.ReadLine();
        }
    }
    public class ClassParent
    {
        public ClassParent()
        {
            Console.WriteLine("Hey this is Parent class");
        }
    }
    public class ClassChild:ClassParent
    {
        public ClassChild()
        {
            Console.WriteLine("Hey this is Child class");
        }
    }
}
