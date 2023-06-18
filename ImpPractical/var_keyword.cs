using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ImpPractical
{
    class var_keyword
    {
        //  var keyword is an implicit way to defining the data type.
        //  var data type looks right hand data according to that it creates the data type. same like python.
        //  statically define
        static void Main1(string[] args)
        {
            var i = 123;    // data type ???
            int i1 = 123;   // much simpler

            string[] Arr = {"shiv","Amit","khobragade","sumit","asmita" };
            var result = from obj in Arr where obj.Length > 5 select new {Len = obj.Length,value = obj};
            foreach(var x in result)
            {
                Console.WriteLine("{0} {1}", x.Len, x.value);
            }
            Console.ReadLine();
        }
    }
}
