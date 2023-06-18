using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class GenericObjectListStoring
    {
        static void Main1(string[] args)
        {
            List<List<object>> list = new List<List<object>>();

            List<object> list1 = new List<object>();
            list1.Add(101);
            list1.Add(102);
            list1.Add(103);

            List<object> list2 = new List<object>();
            list2.Add("string1");
            list2.Add("string2");
            list2.Add("string3");

            list.Add(list1);
            list.Add(list2);

            foreach(List<object> objList in list)
            {
                foreach(object obj in objList)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
