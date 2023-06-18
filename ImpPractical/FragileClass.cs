using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class FragileClass
    {
        static void Main1(string[] args)
        {
            Child objChild = new Child();
            int i = 100;
            objChild.HandleNumeric(i);
            Parent p = new Parent();
            p.HandleNumeric(i);
            Console.ReadLine();
        }
    }
    class Parent
    {
        public virtual void HandleNumeric(int d)
        {
            Console.WriteLine("Parent Nemeric");
        }
    }
    class Child : Parent 
    {
        public void HandleNumeric(double d)
        {
            Console.WriteLine("Child Nemeric");
        }
    }
}
