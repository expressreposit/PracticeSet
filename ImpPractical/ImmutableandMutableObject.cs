using System;
using System.Collections.Generic;
using System.Text;

namespace ImpPractical
{
    class ImmutableandMutableObject
    {
        
        static void Main1(string[] args)
        {
            //  Immutable object:   Once it loaded it can not be changed Internally or Externally
            Currency objCurr = new Currency("INR", "INDIA");
            //objCurr.CountryName = "d";    cannot be change its readonly.
            var v1 = objCurr.CountryName;
            Console.WriteLine(v1);
        }
    }
    class Currency
    {
        //  step 2 : constructor to pass data
        public Currency(string currName, string CountryNam)
        {
            _CurrencyName = currencyName;
            _CountryName = CountryNam;
        }
        //  step 3 : readonly variable once it assign its not changeable
        private readonly string _CurrencyName;
        public string currencyName
        {
            get { return _CurrencyName; }
            //set { _CurrencyName = value; }    //  step 1 : remove or comment set property
        }
        private readonly string _CountryName;
        public string CountryName
        {
            get { return _CountryName; }
            //set { _CountryName = value; }     //  step 1 : remove or comment set property
        }
        public void AddChange()
        {
            //_CountryName = "NewName";
        }
    }
}
