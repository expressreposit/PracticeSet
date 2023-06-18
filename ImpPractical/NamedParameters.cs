using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class NamedParameters
    {
        static void Main1(string[] args)
        {
            PersonalDetail obj = new PersonalDetail();
            obj.AddPersonalDetail(Name:"amit",FirstName:"Amit",LastName:"Khobragade",PetName:"amu",ShortName:"ami");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class PersonalDetail
    {
        public  void AddPersonalDetail(string Name, string FirstName,string LastName, string PetName, string ShortName)
        {
        }
    }
}
