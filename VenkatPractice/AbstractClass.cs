using System;
using System.Collections.Generic;
using System.Text;

namespace VenkatPractice
{
    class AbstractClass // why and when we use Abstract class with examples.
    {
        //So, in short, we would create an abstract class, when want to move the common functionality of 2 or more related classes into a base class and when,
        //we don't want that base class to be instantiated.
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee() { ID = 101, FirstName = "Amit", LastName = "Khobragade",AnnualSalary=60000 };
            ContractTimeEmployee cte = new ContractTimeEmployee() { ID = 102, FirstName = "Sumit", LastName = "Khobragade", HourlyPay = 300, TotalHoursWorked = 40 };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            
            Console.ReadLine();
        }
    }
    abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName() // Get FullName method concatination.
        {
            return this.FirstName + " " + this.LastName;
        }
        public abstract int GetMonthlySalary(); //  Abstarct method to force implementation in derived class other-wise it get compile time ERROR.
    }
    class FullTimeEmployee:BaseEmployee
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()  //  force to implement Abstract method.
        {
            return this.AnnualSalary / 12;
        }
    }
    class ContractTimeEmployee:BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }
        public override int GetMonthlySalary()  //  force to implement Abstract method.
        {
            return this.HourlyPay * TotalHoursWorked;
        }
    }
}
