using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicPrograms
{
    class SearchElementArray
    {
        static void Main22()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int[] rotated = Rotate(values, 3);

            Console.WriteLine(string.Join(", ", rotated));
            Console.ReadLine();
        }
        public static int[] Rotate(int[] ar, int k)
        {
            if (k <= 0 || k > ar.Length - 1)
                return ar;
            return ar.Skip(k)            // Start with the last elements
                     .Concat(ar.Take(k)) // Then the first elements
                     .ToArray();         // Then make it an array
        }
    }
}
