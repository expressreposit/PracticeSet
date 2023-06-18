using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using System.Linq;
namespace ImpPractical
{
    class AutoMappers
    {
        //  In automapper property name are same data can be transfer easily.
        static void Main1(string[] args)
        {
            Person per = new Person();
            per.FirstName = "Amit";
            per.LastName = "khobragade";
            //create map
            //Mapper.CreateMap<Person, Employee>().
            //  use the created map
            //Employee emp = Mapper.Map<Employee>(per);
        }
        
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }

    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
