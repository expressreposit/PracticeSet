using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    //Program to check if input is an integer or a string
    class CheckInputStringOrInteger
    {
        // Returns true if s is a
        // number else false
        static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }

        // Driver code
        static public void Main1(String[] args)
        {// check input is string or num
            string str = "abc1";
            // Function returns 1 if all elements
            // are in range '0 - 9'
            for (int i = 0; i < str.Length; i++)
                if (char.IsDigit(str[i]) == true)
            Console.WriteLine("Integer");
            else
                Console.WriteLine("String");
        }
    }
}
