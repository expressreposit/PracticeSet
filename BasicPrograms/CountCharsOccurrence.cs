using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    /*
         Count character occurrence of a string using dictionary KeyValuePair C#?
     */
    class CountCharsOccurrence
    {
        static void Main1(string[] a)
        {//Count character occurrence of a string
            Dictionary<char, int> dicList = new Dictionary<char, int>();
            Console.WriteLine("Enter charater sting");
            string str = "djjdfsjdj,,sghd,57 6 nvd 55599";
            foreach (var chr in str)
            {
                int count = 0;
                if (dicList.ContainsKey(chr))
                {
                    count = dicList[chr];
                }
                dicList[chr] = count + 1;
            }
            foreach (KeyValuePair<char, int> pair in dicList)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }
            Console.ReadLine();
        }
    }
}
/*  output
 Enter charater sting
hello good morning have a great day
h = 2
e = 3
l = 2
o = 4
  = 6
g = 3
d = 2
m = 1
r = 2
n = 2
i = 1
a = 4
v = 1
t = 1
y = 1
 */