using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-----------------------------------FACTORIAL OF A NUMBER USING RECURSION");
            int number = Convert.ToInt16(Console.ReadLine());
            //CALL FACTORIAL FUNCTION.
            //Console.WriteLine(factorialNumRecursion.FactorialNumber(number));
            Console.WriteLine(FactorialNumber1(number));
            Console.ReadLine();
        }
        public static int FactorialNumber1(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * (FactorialNumber1(number - 1));
        }
    }
}
