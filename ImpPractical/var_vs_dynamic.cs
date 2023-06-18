using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class var_vs_dynamic
    {
        static void Main1(string[] args)
        {
            // compile time early bounded
            var x = "string1";  //  var is early bounded and static check at compile time based on value it will assign data type.
            int len = x.Length;

            // run time late bounded
            dynamic d = "string2";
            int len1 = d.Length;

            dynamic c = "";
            var a = c;
            dynamic b = a;
            Console.WriteLine("{0} \n{1}", len.ToString(), len1.ToString());
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
