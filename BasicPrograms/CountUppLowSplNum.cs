using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class CountUppLowSplNum
    {
        //Count Uppercase, Lowercase, special character and numeric values
        public static void Main1(string[] args)
        {
            string str = "#GeeKs01fOr@gEEks07";
            int upper = 0, lower = 0;
            int number = 0, special = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= '0' && ch <= '9')
                    number++;
                else
                    special++;
            }
            Console.WriteLine("Upper case letters : " + upper);
            Console.WriteLine("Lower case letters : " + lower);
            Console.WriteLine("Number : " + number);
            Console.WriteLine("Special characters : " + special);
        }
    }
}
