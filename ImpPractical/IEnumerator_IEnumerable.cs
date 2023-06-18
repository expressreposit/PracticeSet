using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class IEnumerator_IEnumerable
    {
        static void Main1(string[] args)
        {
            List<int> oYears = new List<int>();
            oYears.Add(1990);
            oYears.Add(1991);
            oYears.Add(1992);
            oYears.Add(1993);
            oYears.Add(2001);
            oYears.Add(2002);
            oYears.Add(2003);
            oYears.Add(2004);
            oYears.Add(2005);
            //  IEnumerable use IEnumerator internally
            IEnumerable<int> IEnum = (IEnumerable<int>)oYears;
            //IEnum.GetEnumerator;
            foreach(int i in IEnum)
            {
                Console.WriteLine(i);
            }

            //  IEnumerator has remember the state but IEnumerable does not.
            IEnumerator<int> IEnumerat = oYears.GetEnumerator();
            while(IEnumerat.MoveNext())
            {
                Console.WriteLine(IEnumerat.Current.ToString());
            }
            Iterate1990To2001(oYears);
            Console.ReadLine();
        }
        static void Iterate1990To2001(IEnumerable<int> ienum)
        {
            //  iterate value from 1990 to 2001

            foreach(int i in ienum)
            {
                Console.WriteLine(i);
                if (i > 2000)
                {
                    Iterate2001ToAbove(ienum);
                }
            }
        }
        static void Iterate2001ToAbove(IEnumerable<int> ienum)
        {
            //  iterate value from 1990 to 2001
            //  IEnumerable does not remember the state but IEnumerator does it.
            foreach (int i in ienum)
            {
                Console.WriteLine(i);
            }
        }
        static void Iterate1990To2001(IEnumerator<int> ienum)
        {
            //  iterate value from 1990 to 2001
            while(ienum.MoveNext())
            {
                Console.WriteLine(ienum.Current.ToString());
                if(Convert.ToInt16(ienum.Current)>2000)
                {
                    Iterate2001ToAbove(ienum); 
                }
            }
        }
        static void Iterate2001ToAbove(IEnumerator<int> ienum)
        {
            //  iterate value from 1990 to 2001
            //  IEnumerator has remember the state but IEnumerable does not.
            while (ienum.MoveNext())
            {
                Console.WriteLine(ienum.Current.ToString());
            }
        }
    }
}
