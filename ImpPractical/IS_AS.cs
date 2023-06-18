using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class IS_AS
    {
        static void Main1(string[] args)
        {
            //  "IS" str1 variable of type is string.
            object str1 = "Amit";
            if (str1 is string)
                Console.WriteLine("This is of same Type");
            //  Can we convert str1  string "AS" object.
            string x1 = str1 as string;
            Console.ReadLine();
        }
    }
}
