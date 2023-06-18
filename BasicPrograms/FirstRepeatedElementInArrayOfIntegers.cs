using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    public class FirstRepeatedElementInArrayOfIntegers
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[] { 10, 5, 3, 4, 3, 5, 6,3 };
            printFirstRepeating(arr);
            
            Console.ReadLine();
        }
        // This function prints the first repeating element in arr[]
        static void printFirstRepeating(int[] arr)
        {
            // Initialize index of first repeating element
            int min = -1;

            // Creates an empty hashset
            HashSet<int> set = new HashSet<int>();

            // Traverse the input array from right to left
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // If element is already in hash set, update min
                if (set.Contains(arr[i]))
                {
                    min = i;
                }
                else // Else add element to hash set
                {
                    set.Add(arr[i]);
                }
            }
            // Print the result
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is "+ arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
        }
    }
}
