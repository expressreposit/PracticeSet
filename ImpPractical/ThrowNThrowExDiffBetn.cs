using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class ThrowNThrowExDiffBetn
    {
        static void Main1(string[] args)
        {
            try
            {
                Method2();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
                Console.ReadLine();
            }
        }

        public static void Method2()
        {
            try
            {
                Method1();
            }
            catch(Exception ex)
            {
                throw ;
            }
        }
        public static void Method1()
        {
            try
            {
                throw new Exception("This thrown from Method1");
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
