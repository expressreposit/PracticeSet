using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class JaggedArray   //  is an Array of Arrays
    {
        static void Main1(string[] args)
        {
            //  string array to store employee name.
            string[] employeeName = new string[3];
            employeeName[0] = "Mark";
            employeeName[1] = "Mat";
            employeeName[2] = "John";

            //  Jagged array to store employee qualification.
            string[][] jaggedArray = new string[3][];

            // Set the size of the first string array to 3, as we want to store 3 qualifications for Mark
            jaggedArray[0] = new string[3];
            // Set the size of the second string array to 1, as we want to store only 1 qualification for Matt
            jaggedArray[1] = new string[1];
            // Set the size of the third string array to 2, as we want to store 2 qualifications for John
            jaggedArray[2] = new string[2];

            // Set the values for the first string array
            jaggedArray[0][0] = "Bachelor";
            jaggedArray[0][1] = "Master";
            jaggedArray[0][2] = "Doctorate";

            // Set the values for the second string array
            jaggedArray[1][0] = "Bachelor";

            // Set the values for the third string array
            jaggedArray[2][0] = "Bachelor";
            jaggedArray[2][1] = "Master";

            // Loop thru and print out the elements of Jagged array
            for (int i=0;i<jaggedArray.Length;i++)
            {
                Console.WriteLine(employeeName[i]);
                Console.WriteLine("---------------");
                string[] innerArray = jaggedArray[i];
                for(int j =0;j<innerArray.Length;j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
