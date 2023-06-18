using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
                                                                                                        
namespace BasicPrograms
{
    class ReverseStrigs
    {
        static void Main12(string[] a)
        {
            Console.WriteLine("Enter string for Reverse wordm");
            string str = Console.ReadLine();

            Console.WriteLine(Reverse(str));
            Console.WriteLine(strReverse(str));

            Console.ReadLine();
        }
        
        public static string Reverse(string str)
        {//reverse string only
            str = "I am Amit";
            //LINQ has Reverse() for string array
            return new string(str.Reverse().ToArray());
        }
        public static string strReverse(string str)
        {
            int strLength = str.Length;
            char[] array = new char[strLength];
            for (int i = 0; i < strLength; i++)
            {
                array[i] = str[strLength - 1 - i];
            }
            return new string(array);
        }
    }
}
