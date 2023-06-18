using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
     static class PrimeNumber
    {
        /*  Prime number is a number that is greater than 1 and divided by 1 or itself. 
            In other words, prime numbers can't be divided by other numbers than itself or 1. 
            For example 2, 3, 5, 7, 11, 13, 17, 19, 23.... are the prime numbers.
        */
        static void Main12(string[] args)
        {
            Console.WriteLine("-----------------------------------Prime Number");
            PrimeNumber.checkPrimeNumber();

            Console.ReadLine();
        }
        public static void checkPrimeNumber()
        {
            bool IsPrimeNum = true;
            Console.WriteLine("Please enter numbers for get prime number. ");
            long number = Convert.ToInt32(Console.ReadLine());
            for (long p = 2; p <= number; p++)
            {
                for (long q = 2; q <= number; q++)
                {
                    if (p != q && p % q == 0)
                    {
                        IsPrimeNum = false;
                        break;
                    }
                }
                if (IsPrimeNum)
                {
                    Console.WriteLine("The given number is prime: "+p);
                }
                IsPrimeNum = true;
            }
        }
    }
}
