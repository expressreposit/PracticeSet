using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTypes
{
    class indexers
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("----------------------------------------------Indexer");
            indexers inx = new indexers();
            inx[0] = "Amit k";
            inx[1] = "shubham";
            inx[2] = "lucky day";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(inx[i]);
            }

            Console.ReadLine();
        }
        public string[] index_name = new string[25];
        public string this[int index]
        {
            get { return index_name[index]; }
            set { index_name[index] = value; }
        }
    }
}
