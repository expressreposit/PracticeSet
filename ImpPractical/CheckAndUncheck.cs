using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class CheckAndUncheck
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(int.MaxValue);

            int y = 2147483647;
            int x = 2147483647;

            //const key checked on compile time its overflow or not in checked mode
            const int a = 2147483647;
            const int b = 2147483647;
            try
            {
                //  checked keyword helps to check if the destination data type is overflow in a arithmatic calculation.
                int z = checked(x + y);
                Console.WriteLine(z.ToString());

                //  unchecked keyword behave (ALMOST) the same way as default, But is useful to bypass the const data type checks.
                int c = unchecked(a + b);   //bypass the overflow error use uncheched function.
                
                Console.WriteLine(c.ToString());
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
