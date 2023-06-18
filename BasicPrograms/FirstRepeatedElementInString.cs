using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    public class FirstRepeatedElementInString
    {
        static void Main1(string[] args)
        {
            string str = "geeksforgeeks";
            char[] arr = str.ToCharArray();
            
            Console.WriteLine(FirstRepeating(arr));
            
            Console.ReadLine();
        }
        static char FirstRepeating(char[] str)
        {
            // Creates an empty hashset
            HashSet<char> h = new HashSet<char>();

            // Traverse the input array
            // from left to right
            for (int i = 0; i <= str.Length - 1; i++)
            {
                char c = str[i];
                // If element is already in hash set,
                // update x and then break
                if (h.Contains(c))
                {
                    return c;
                }
                else // Else add element to hash set
                {
                    h.Add(c);
                }
            }
            return '\0';
        }
    }
}
