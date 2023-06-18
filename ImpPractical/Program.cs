using System;

namespace ImpPractical
{
    class Program
    {
        static void Main1(string[] args)
        {
            string str = "Amit kishor khobragade 9137029119";
            string fName = "";
            string mName = "";
            string lName = "";
            double mobile = 0;
            ParseData(str, out fName,out mName,out lName,out mobile);
            Console.WriteLine("First Name: " + fName);
            Console.WriteLine("Middle Name: " + mName);
            Console.WriteLine("Last Name: " + lName);
            Console.WriteLine("Mobile Number: " + mobile.ToString());
            Console.WriteLine("----------------------------------------------------Using Tuple Example");
            var myInformation = ParseTupleData(str);
            Console.WriteLine("First Name: " + myInformation.Item1);
            Console.WriteLine("Middle Name: " + myInformation.Item2);
            Console.WriteLine("Last Name: " + myInformation.Item3);
            Console.WriteLine("Mobile Number: " + myInformation.Item4.ToString());
            Console.WriteLine("----------------------------------------------------Using Anonymous Type");
            var myAnonymousInfo = Cast(ParseAnonymousData(str),new {fName,mName,lName,mobile });
            Console.WriteLine("First Name: " + myAnonymousInfo.fName);
            Console.WriteLine("Middle Name: " + myAnonymousInfo.mName);
            Console.WriteLine("Last Name: " + myAnonymousInfo.lName);
            Console.WriteLine("Mobile Number: " + myAnonymousInfo.mobile);

            Console.ReadLine();
        }
        //
        static object ParseAnonymousData(string strData)
        {
            string[] ArrayData = new string[3];
            ArrayData = strData.Split(" ");
            return new { fNmae = ArrayData[0], mNmae = ArrayData[1], lNmae = ArrayData[2], mobile = Convert.ToDouble(ArrayData[3]) };
        }
        //Cast Type function
        static T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }

        //example for parse data using return Tuple
        static Tuple<string,string,string,double> ParseTupleData(string strData)
        {
            string[] ArrayData = new string[3];
            ArrayData = strData.Split(" ");
            return Tuple.Create<string, string, string, double>(ArrayData[0], ArrayData[1], ArrayData[2], Convert.ToDouble(ArrayData[3]));
        }

        //simple example for parse data from out keyword
        static void ParseData(string strData, out string fName, out string mName, out string lName, out double mobile)
        {
            //string[] arrayData = strData.Split(" ");
            string[] ArrayData = new string[3];
            ArrayData = strData.Split(" ");
            fName = ArrayData[0];
            mName = ArrayData[1];
            lName = ArrayData[2];
            mobile = Convert.ToDouble(ArrayData[3]);
        }
    }
}
