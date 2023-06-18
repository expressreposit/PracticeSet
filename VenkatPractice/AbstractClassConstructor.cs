using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class AbstractClassConstructor  //   Can an abstract class have a constructor
    {
        static void Main1(string[] args)
        {
            CorporateCustomer CC = new CorporateCustomer();
            Console.WriteLine( CC.id);

            SavingsCustomer SC = new SavingsCustomer();
            Console.WriteLine(SC.id);

            Console.ReadLine();

        }
    }
    //  Note: Abstract classes can't be directly instantiated. The abstract class constructor gets executed thru a derived class. So,
    //  it is a good practice to use protected access modifier with abstract class constructor. Using public doesn’t make sense.
    public abstract class CustomerClass
    {
        private Guid _ID;
        protected CustomerClass()
        {
            this._ID = Guid.NewGuid();
        }
        public Guid id
        {
            get { return this._ID; }
        }
    }
    public class CorporateCustomer: CustomerClass
    {
    }
    public class SavingsCustomer: CustomerClass
    {
    }
}
