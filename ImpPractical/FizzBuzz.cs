using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class FizzBuzz
    {
        static void Main1(string[] args)
        {
            //  step 1: Print number from 1 to 100.
            for (int j = 1; j <= 100; j++)
            {
                string result = "";
                //  step 2: Divisible by 3 print Fizz.
                if (j % 3 == 0)
                    result = "Fizz ";
                //  step 3: Divisible by 5 print Buzz.
                if (j % 5 == 0)
                    result = result + "Buzz";
                //  step 4: Divisible by 3 and 5 print FizzBuzz
                //  step 5: Print the Number as it is if number not divisible by 3 and 5
                if (result.Length == 0)
                    result = j.ToString();
                    Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
