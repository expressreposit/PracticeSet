using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class AbstractMethodFromAn_AbstractConstructor
    {
        static void Main1(string[] args)
        {
            CorporateCustomerB CC = new CorporateCustomerB();
            SavingsCustomerC SC = new SavingsCustomerC();

            Console.ReadLine();
        }
    }
    public abstract class CustomerClassA
    {
        public CustomerClassA()
        {
            Print();
        }
        public abstract void Print();
    }
    public class CorporateCustomerB : CustomerClassA
    {
        public override void Print()
        {
            Console.WriteLine("CorporateCustomerB Print() method called");
        }
    }
    public class SavingsCustomerC : CustomerClassA
    {
        public override void Print()
        {
            Console.WriteLine("SavingsCustomerC Print() method called");
        }
    }
}
