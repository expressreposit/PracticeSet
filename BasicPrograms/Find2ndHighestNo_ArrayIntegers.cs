using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrograms
{
    public class Find2ndHighestNo_ArrayIntegers
    {
        static void Main1(string[] args)
        {
            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            Array.Sort(array); //sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            //Display purpose Array values foreach loop
            foreach (var result in array)
                Console.Write(result + " ");
            
            //Using LINQ
            int secondHighest = (from number in array
                                 orderby number descending
                                 select number).Distinct().Skip(1).First();

            //Using Min, Max int function
            int Smallest = array.Min();
            int Largest = array.Max();
            foreach (int i in array)
                if (i > Smallest && i < Largest)
                    Smallest = i;
            Console.WriteLine(Smallest);
            Console.ReadLine();
        }
    }
}
