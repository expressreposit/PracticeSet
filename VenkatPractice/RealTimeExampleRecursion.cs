using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VenkatPractice
{
    class RealTimeExampleRecursion
    {
        //Probably in an interview, an interviewer may ask you to give an example, where you have used recursion in your project. 
        //To find all the files in a folder and in all the sub-folders in the hierarchy.This is a very good example of where we could use recursion.
        static void Main1(string[] args)
        {
            //Console.WriteLine("Please enter the folder Path");
            //string path = Console.ReadLine();
            //FindFile(path);

            //int n = 2;
            //while(n>0)
            //{
            //    n++;
            //    n -= 2;
            //    Console.WriteLine(n);
            //}
            //int i = 0;int sum = 0;
            //while(i<100)
            //{
            //    sum = sum + i;sum = i + sum;i += 1;
            //    Console.WriteLine(sum);
            //}
            int n = fib(100,2000);

            Console.WriteLine(n);

            Console.ReadLine();
        }
        public static int fib(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return fib(b, a % b);

        }

        private static void FindFile(string path)
        {
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }
            foreach(string directory in Directory.GetDirectories(path))
            {
                FindFile(directory);
            }
        }
    }
}
