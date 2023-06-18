using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    //  parent element completely replace with data type, method
    class shadowing
    {
        static void Main1(string[] args)
        {
            //  old client 
            Sales objSales=new Sales ();
            objSales.InvoiceNumber = 1213232332;    //  existing old client does not disturb the functionality.

            // New client fulfill the new requirement.
            SalesVersion2 objSalesV2 =new SalesVersion2 ();
            objSalesV2.InvoiceNumber = "2323ewe2323";


            classA1 a1 = new classA1();
            classA2 a2 = new classA2();

            // parent class i is variable.
            a1.i = 123;

            //  child class i has been converted into a method.
            a2.i();
        }
    }
    //  shadowing replaces the current element of the parent variable
    //  while overriding only changing the implementation.
    public class Sales  // realtime example
    {
        public int InvoiceNumber { get; set; }  //Invoice number use in lot of places its a rockstar class.
        // If one day another client says he want Invoice Number is AlphaNumeric.
    }

    public class SalesVersion2:Sales
    {
        // use new keyword for new implementation of InvoiceNumber bcz compiler gives warning.
        public new object InvoiceNumber { get; set; }
        //public object InvoiceNumber { get; set; }
    }
    class classA1
    {
        public int i = 0;
    }
    class classA2 : classA1
    {
        public void i()
        {

        }
    }
}
