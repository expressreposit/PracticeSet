using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program   //Select and SelectMany in LINQ
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee { Name = "Amit", skills = new List<string> { "c#", "C++", "Java" } };
            Employee emp2 = new Employee { Name = "Shubham", skills = new List<string> { "SQL Server", "Oracle", "MongoDB" } };
            Employee emp3 = new Employee { Name = "Harry", skills = new List<string> { "ReactJS", "NextJS", "Angular" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            //Query using "select" 
            IEnumerable<List<string>> resultSelect = employees.Select(e => e.skills);
            Console.WriteLine("Query Using select() :\n");
            foreach (List<string> skillList in resultSelect)
            {
                foreach(string skills in skillList)
                {
                    Console.WriteLine(skills);
                }
                Console.WriteLine();
            }
            //Query using "selectMany"
            IEnumerable<string> resultSelectMany = employees.SelectMany(e => e.skills);
            Console.WriteLine("Query Using selectMany() :\n");
            foreach (string skill in resultSelectMany)
            {
                Console.WriteLine(skill);
            }
            Console.ReadLine();
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public List<string> skills { get; set; }
    }
}
