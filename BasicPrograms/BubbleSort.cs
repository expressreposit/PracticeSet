using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class BubbleSort
    {
        static void Main1(string[] args) 
        {
            Console.WriteLine("-----------------------------------Bubble Sort");
            BubbleSort.bubbleSort();

            Console.ReadLine();
        }
        public static void bubbleSort()
        {
            int[] intArray = new int[] { 213, 32, 392, 352, 43, 332, 435, 345, 432, 5 };
            int tempVal;    
            int ArrLen = intArray.Length;
            for (int i = (ArrLen - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (intArray[j - 1] > intArray[j])
                    {
                        tempVal = intArray[j - 1];
                        intArray[j - 1] = intArray[j];
                        intArray[j] = tempVal;
                    }
                }
            }
            for (int p = 0; p < ArrLen; p++)
            {
                Console.WriteLine(intArray[p]);
            }
        }
    }
}
