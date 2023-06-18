using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicPrograms
{
    class CheckStrNumUppLowSplAllPresentOrNot
    {
        //Check if a string contains uppercase, lowercase, special characters and numeric values
        // Function that checks if a string
        // contains uppercase, lowercase
        // special character & numeric value
        static void isAllPresent(string str)
        {
            // ReGex to check if a string
            // contains uppercase, lowercase
            // special character & numeric value
            string regex = "^(?=.*[a-z])(?=."
                        + "*[A-Z])(?=.*\\d)"
                        + "(?=.*[-+_!@#$%^&*., ?]).+$";
            // Compile the ReGex
            Regex p = new Regex(regex);
            // If the string is empty
            // then print No
            if (str == null)
            {
                Console.Write("No");
                return;
            }
            // Find match between given string
            // & regular expression
            Match m = p.Match(str);
            // Print Yes if string
            // matches ReGex
            if (m.Success)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
        // Driver Code
        public static void Main1()
        { // Given string CheckStrNumUppLowSplAllPresentOrNot
            string str = "#GeeksForGeeks123@";
            string regex = "^(?=.*[a-z])(?=."
                         + "*[A-Z])(?=.*\\d)"
                         + "(?=.*[-+_!@#$%^&*., ?]).+$";
            Regex p = new Regex(regex);
            // If the string is empty
            if (str == null)
            {
                Console.Write("No");
                return;
            }
            Match m = p.Match(str);
            if (m.Success)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}
