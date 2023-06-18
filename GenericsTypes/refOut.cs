using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTypes
{
    /*
        It is also known as input parameter.
        Initialized not must to inside the method. 
        Before calling the method must be initialize the values of the variable.
     */
    class refOut
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-------Ref and Out");
            int add;
            refOut.Method(10, 10, out add);
            Console.WriteLine("out value : " + add);
            int a=1;
            refOut.callRef(ref a);
            Console.WriteLine("ref value : " + a);
            
            Console.ReadLine();
        }
        
        //out keyword is a two-ways communication.
        public static void Method(int a, int b, out int add)
        {
            add = a + b;
        }

        //Ref keyword is a one-way communication while the
        public static void callRef(ref int a)
        {
            a += 110;
        }
    }
}
