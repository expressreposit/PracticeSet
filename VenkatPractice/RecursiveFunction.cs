using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class RecursiveFunction
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            double factorial = Factorial(number);
            Console.WriteLine("Factorial of " + number.ToString() + " " + factorial.ToString());

            factorial = FactorialWithRecursive(number);
            Console.WriteLine("Factorial With Recursive of " + number.ToString() + " " + factorial.ToString());

            Console.ReadLine();
        }
        public static double FactorialWithRecursive(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
