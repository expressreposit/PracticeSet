using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Armstrong
    {
        /*  An Armstrong number is one whose sum of digits raised to the power three equals the number itself.
            371, for example, is an Armstrong number because 3**3 + 7**3 + 1**3 = 371.
            In the range 0 to 999 there exists six Armstrong numbers- 0, 1, 153, 370, 371 and 407
            qoutiont, denominator, remainder
         */
        static void Main1(string[] args)
        {
            Console.WriteLine("-----------------------------------Armstrong Number");
            Console.WriteLine("Enter the number.");
            string myStr = Console.ReadLine();
            int converted = int.Parse(myStr);
            int armstrong = ArmstrongNumber(converted);
            Console.WriteLine(armstrong);

            Console.ReadLine();
        }
        static int ArmstrongNumber(int val)
        {
            int fact, remaind, total = 0;
            while (val > 0)
            {
                fact = val / 10;
                remaind = val % 10; 
                //  when 41 is divided by 7, the quotient is 5 and the remainder is 6.
                total = total + remaind * remaind * remaind;
                val = fact;
            }
            return total;
        }
        public static void ArmstrongNum()
        {
            Console.WriteLine("Enter the number.");
            string myStr = Console.ReadLine();
            int converted = int.Parse(myStr);
            int armstrong = ArmstrongNumber(converted);
            Console.WriteLine(armstrong);
        }
    }
}
