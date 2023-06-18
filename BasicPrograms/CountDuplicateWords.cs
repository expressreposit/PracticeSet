using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrograms
{
    class CountDuplicateWords
    {
        static string key = "HI MY NAME IS ANIL HI MY NAME IS ANIL HI MY NAME IS ANIL".ToLower();
        public static int CountWords(string key)
        {
            string[] strList = key.Split(' ');
            Dictionary<int, string> dicList = new Dictionary<int, string>();

            for (int i = 0; i < strList.Length; i++)
            {
                dicList.Add(i, strList[i]);
            }
            return dicList.Where(x => x.Value == key).ToList().Count;
        }
        static void Main1(string[] ax)
        {
            string Word = "HI MY NAME IS AMIT HI MY MY NAME NAME ISIS IS HI MY NAME IS ANIL HI MY NAME IS ANIL";
            //Console.WriteLine("Enter the word!..");
            //Word = Console.ReadLine();   // Read the Input string from User at Run Time  
            var Value = Word.Split(' ');  // Split the string using 'Space' and stored it an var variable  
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++) //loop the splited string  
            {
                if (RepeatedWordCount.ContainsKey(Value[i])) // Check if word already exist in dictionary update the count  
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Repeated words and counts");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  // Print the Repeated word and its count  
            }
            Console.ReadLine();
        }
    }
}
