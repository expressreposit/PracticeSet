using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class SelectionSorting
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("-----------------------------------Selection Sort");
            SelectionSorting.SelectionSort();

            Console.ReadLine();
        }
        public static void SelectionSort()
        {
            int[] arrayNumber = new int[10];
            int minNumber;
            bool isNumber = false;
            int sizeNumber;

            Console.WriteLine("Enter the mumbers of element in the array.");

            string sizeStr = Console.ReadLine();
            isNumber = Int32.TryParse(sizeStr, out sizeNumber);

            if (isNumber)
            {
                Console.WriteLine("Enter array values numeric.");
                for (int i = 0; i < sizeNumber; i++)
                {
                    int tempVal;
                    string arrayValue = Console.ReadLine();
                    isNumber = Int32.TryParse(arrayValue, out tempVal);
                    if (isNumber)
                    {
                        arrayNumber[i] = tempVal;
                    }
                    else
                    {
                        Console.WriteLine("Enter the array numeric only values.");
                        break;
                    }
                }

                for (int j = 0; j < sizeNumber - 1; j++)
                {
                    minNumber = j;

                    for (int k = j + 1; k < sizeNumber; k++)
                    {
                        if (arrayNumber[minNumber] > arrayNumber[k])
                        {
                            minNumber = k;
                        }
                    }

                    if (minNumber != j)
                    {
                        int finalNum = arrayNumber[j];
                        arrayNumber[j] = arrayNumber[minNumber];
                        arrayNumber[minNumber] = finalNum;
                    }
                }

                Console.WriteLine("Results of Selection Sort.");
                for (int l = 0; l < sizeNumber; l++)
                {
                    Console.WriteLine(arrayNumber[l]);
                }
            }
            else
            {
                Console.WriteLine("The array numeric only.");
            }
        }

    }
}
