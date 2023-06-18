using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class IsPalindrome
    {
        static void Main11(string[] args)
        {
            Console.WriteLine("-----------------------------------Palindrome Number");
            IsPalindrome.palindromeNum();

            Console.ReadLine();
        }
        public static void palindromeNum()
        {
            string PalindromeStr = string.Empty;
            Console.WriteLine("Enter a String");

            string str = Console.ReadLine();
            int m = str.Length;

            for (int n = m - 1; n >= 0; n--)
            {
                PalindromeStr = PalindromeStr + str[n];
            }

            if (PalindromeStr == str)
            {
                Console.WriteLine(str + " is a valid palindrome.");
            }
            else
            {
                Console.WriteLine(str + " is not a valid palindrome.");
            }
            Console.WriteLine(PalindromeStr);
        }
    }
}
