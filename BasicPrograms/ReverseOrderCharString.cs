using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicPrograms
{
    class ReverseOrderCharString
    {
        static void Main(string[] a)
        {
            string s = "Amit is Developer";
            string result = LINQReverseWords(s);
            string result1 = ReverseWords(s);
            string result2 = ReverseWordsUsingLINQ(s);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            string[] str = new string[] { "max", "min", "avg", "max", "avg", "min" };
            var firstDup = str.Select((s, index) => new { s, index })
                          .Where(x => x.s == "avg")
                          .Select(x => x.index)
                          .ToList();
            Console.WriteLine(firstDup);
            Console.ReadLine();
        }
        public static string LINQReverseWords(string s)
        {
            string s1 = "I am amit";
            return string.Join(" ", s1.Split(" ").Select(x => new String(x.ToCharArray().Reverse().ToArray())));
        }
        #region "Solution 1 (Using Loop)"
        public static string ReverseWords(string s)
        {
            string[] array = s.Split(" ");
            string newString = "";
            if (array.Length > 0)
            {
                for (int ai = 0; ai < array.Length; ai++)
                {
                    if (!string.IsNullOrEmpty(newString))
                        newString = newString += " ";
                    char[] charArray = array[ai].ToCharArray();
                    int i = 0, j = charArray.Length - 1;
                    for (int k = 0; k < charArray.Length; k++)
                    {
                        if (j > i)
                        {
                            char temp = charArray[j];
                            charArray[j] = charArray[i];
                            charArray[i] = temp;
                            j--;
                            i++;
                        }
                    }
                    newString += new string(charArray);
                }
            }
            return newString;
        }
        #endregion

        #region "Solution 2 (Using Loop & Linq)"
        public static string ReverseWordsUsingLINQ(string s)
        {
            string[] array = s.Split(" ");
            if (array.Length > 0)
            {
                for (int ai = 0; ai < array.Length; ai++)
                {
                    char[] newarray = array[ai].ToCharArray();
                    Array.Reverse(newarray);
                    array[ai] = new string(newarray);
                }
            }
            return string.Join(" ", array);
        }
        #endregion
    }
}
//Input: s = "Let's take LeetCode contest"
//Output: "s'teL ekat edoCteeL tsetnoc"