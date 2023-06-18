using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ImpPractical
{
    class Volatile_Keyword
    {
        //  loop variable
        private volatile bool _loop = true;
        static void Main1(string[] args)
        {
            Volatile_Keyword v1 = new Volatile_Keyword();
            Thread thread = new Thread(SomeThread);
            thread.Start(v1);

            Thread.Sleep(20);

            v1._loop = false;
            Console.WriteLine("step 2 :- The value is set to flase");
            Console.ReadLine();
        }

        private static void SomeThread(object o1)
        {
            Volatile_Keyword v2 = (Volatile_Keyword)o1;
            Console.WriteLine("step 1 :- Step 1 enter in loop");
            while(v2._loop)
            {

            }
            Console.WriteLine("step 3 :- Exited the loop");

        }
    }
}
