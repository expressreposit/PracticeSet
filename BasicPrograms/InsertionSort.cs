using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class InsertionSort
    {
        public void displayArray(int[] array, int n)
        {
            Console.WriteLine("\nThe sorted array elements.");
            for (int p = 0; p < n; p++)
            {
                Console.WriteLine(array[p]);
            }
        }
        static void Main1(string[] args)
        {
            InsertionSort objIS = new InsertionSort();
            Console.WriteLine("Enter numbers of elements.");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            objIS.AcceptedArrays(array, number);
            objIS.InSort(array, number);
            objIS.displayArray(array, number);
            Console.ReadLine();
        }

        public void AcceptedArrays(int[] array, int n)
        {
            Console.WriteLine("\nEnter the numbers:");
            for (int l = 0; l < n; l++)
            {
                array[l] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void InSort(int[] array, int n)
        {
            for (int val = 1; val <= n - 1; val++)
            {
                for (int m = 1; m <= n - 1; m++)
                {
                    int tempVal = array[m];
                    for (int j = m - 1; j >= 0 && array[j] > tempVal; j--)
                    {
                        array[j + 1] = array[j];
                        array[j] = tempVal;
                    }
                }
            }
        }
    }
}

