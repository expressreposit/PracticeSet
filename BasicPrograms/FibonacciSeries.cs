using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class FibonacciSeries
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("-----------------------------------Fibonacci Series using Recursion and Loop");
            Console.WriteLine("Enter the number.");
            int number = Convert.ToInt32(Console.ReadLine());
            //USING LOOP FOR GET FIBONACCI SERIES.
            FibonacciSeries.FibonicciAlgo(number);

            //USING RECURCIVE METHOD FOR GET FIBONACCI SERIES.
            FibonacciSeries.Fibonacci_Recurcive(0, 1, 1, number);

            Console.ReadLine();
        }
        /// <summary>
        /// USING LOOP FOR GET FIBONACCI SERIES.
        /// </summary>
        public static void FibonicciAlgo(int number)
        {
            int a = -1;
            int b = 1;
            for (int i = 0; i < number; i++)
            {
                int c = b + a;
                a = b;
                b = c;
                Console.Write("{0} ", b);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// USING RECURCIVE METHOD FOR GET FIBONACCI SERIES.
        /// </summary>
        public static void Fibonacci_Recurcive(int a, int b, int counter, int number)
        {
            if (counter <= number)
            {
                Console.Write("{0} ", a);
                Fibonacci_Recurcive(b, a + b, counter + 1, number);
            }
            Console.ReadLine();
        }
    }
}
