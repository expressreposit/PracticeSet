using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class CountMostOccurrenceCharacters
    {
        static void Main1(string[] ss)//No. of words occurenece
        {
            string str = "hello myname is amit my name amit isis amam isamit 12 1 3333";
            Dictionary<char, int> dicList = new Dictionary<char, int>();
            int last = 0;
            Console.WriteLine("Enter the charactor string");
            Console.WriteLine(str);
            foreach (char chr in str)
            {
                int count;
                dicList.TryGetValue(chr, out count);

                count++;
                if (count > last)
                {
                    last = count;
                }
                dicList[chr] = count;
            }
            foreach (KeyValuePair<char, int> charList in dicList)
            {
                if (charList.Value == last)
                {
                    Console.WriteLine("{0}: {1}", charList.Key, charList.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
