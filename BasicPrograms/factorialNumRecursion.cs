using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class factorialNumRecursion
    {
        /// <summary>
        /// FACTORIAL OF A NUMBER USING RECURSION.
        /// </summary>
        public static int FactorialNumber(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * (FactorialNumber(number - 1));
        }
    }
}
