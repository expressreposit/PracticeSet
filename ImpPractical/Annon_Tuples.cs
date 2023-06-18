using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    public class Annon_Tuples
    {
        static void Main1(string[] args)
        {
            string str = "Amit K Khobragade 9137029119";

            var myInfo = Cast(ParseData(str), 
                new { FirstName = "", MiddleName = "", LastName = "", PhoneNumber = 0.0 });

            Console.WriteLine("First Name: " + myInfo.FirstName);
            Console.WriteLine("Middle Name: " + myInfo.MiddleName);
            Console.WriteLine("Last Name: " + myInfo.LastName);
            Console.WriteLine("Phone Number: " +  myInfo.PhoneNumber.ToString());

            Console.ReadLine();
        }

        static object ParseData(string strData)
        {
            string[] ArrayData = new string[3];
            ArrayData = strData.Split(' ');
            return new
            {
                FirstName = ArrayData[0],
                MiddleName = ArrayData[1],
                LastName = ArrayData[2],
                PhoneNumber =Convert.ToDouble(ArrayData[3])
            };
        }

        static T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }
    }
}
