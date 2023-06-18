using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GenericsTypes
{
    /*
        Types of Arrays
            One-dimensional Arrays 
            Two-dimensional Arrays 
            Jagged Arrays 
            Mixed Arrays 
    1. One-dimensional Arrays

        Array Properties
            IsFixedSize => Return a value indicating if an array has a fixed size or not. 
            IsReadOnly => Return a value indicating if an array is read-only or not. 
            LongLength => Return a 64-bit integer that represents total number of items in all the dimensions of an array. 
            Length => Return a 32-bit integer that represents the total number of items in all the dimensions of an array. 
            Rank => Return the number of dimensions of an array . 
     */
    class ArrayTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Array");
            //ArrayClass.ArrayMethod();

            MultiDimentionalArray.MultiDimentionalMethod();

            Console.ReadLine();

        }
    }
    //1. One-dimensional Arrays
    public static class ArrayClass
    {
        public static void ArrayMethod()
        {
            int[] intArray1 = new int[10] { 0,1,2,45,4,5,6,7,8,9};  //hard code array value set.
            int[] intArray = new int[5];
            double[] doubleArray = new double[10];
            char[] charArray = new char[12];
            bool[] boolArray = new bool[5];
            string[] stringArray = new string[15];
            intArray[3] = 101;
            if (intArray.IsFixedSize)
            {
                Console.WriteLine("Array Length: " + intArray.Length.ToString());
                Console.WriteLine("Array Dimension: " + intArray.Rank.ToString());
                Console.WriteLine("Array ReadOnly: " + intArray.IsReadOnly.ToString());
                Console.WriteLine("Array Value: " + intArray.GetValue(3));
            }
            Console.WriteLine();
            if (intArray1.IsFixedSize)
            {
                Console.WriteLine("Array Length: " + intArray1.Length.ToString());
                Console.WriteLine("Array Dimension: " + intArray1.Rank.ToString());
                Console.WriteLine("Array ReadOnly: " + intArray1.IsReadOnly.ToString());
                Console.WriteLine("Array Value: " + intArray1.GetValue(3));
            }
        }
    }

    //2. Two-Dimensional Arrays
    public static class MultiDimentionalArray
    {
        public static void MultiDimentionalMethod()
        {
            string[,] strName = new string[2, 2] { {"Amit","MCM" },{"Shubham","BE" } };
            if(strName.Length>0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Education");
                Console.Write(dt.Columns[0].ColumnName.ToString());
                Console.Write("\t\t");
                Console.Write(dt.Columns[1].ColumnName.ToString());
                for(int i =0; i<strName.GetLength(0);i++)
                {
                    dt.Rows.Add();
                    dt.Rows[i]["Name"] = strName[i, 0].ToString();
                    dt.Rows[i]["Education"] = strName[i, 1].ToString();
                    Console.Write("\n");
                    Console.Write(dt.Rows[i]["Name"]);
                    Console.Write("\t\t");
                    Console.Write(dt.Rows[i]["Education"]);
                }
            }
        }
    }

    //jagged Array Program
    public class jaggedArrayProgram
    {

    }
}
