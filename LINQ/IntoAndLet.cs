using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    #region hiddencode
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public string EmpID { get; set; }
    //    public int Salary { get; set; }

    //}
    #endregion

    class Mobile
    {
        public string Provider { get; set; }
        public string ModelName { get; set; }
        public string ModelNumber { get; set; }
        public int MemoryCard { get; set; }
    }
    public class IntoAndLet
    {
        static void Main1(string[] args)
        {
            #region Commented Code
            //int num, r, c, z, n;
            //Console.WriteLine("Enter maximum no. of rows : ");
            //num = Convert.ToInt32(Console.ReadLine().ToString());

            //z = num;
            //for (r = 1; r <= num; r++,z=num)
            //{
            //    for (c = 1, n = r; c <= r; c++,n = n + z)
            //    {
            //        Console.WriteLine(n+"\t");

            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadLine();
            #endregion Commented Code

            List<Mobile> objMobileCollection = new List<Mobile> {
             new Mobile{Provider="Apple",ModelName="IPhone3",ModelNumber="I100",MemoryCard=4},
             new Mobile{Provider="Apple",ModelName="IPhone4",ModelNumber="I101",MemoryCard=8},
             new Mobile{Provider="Apple",ModelName="IPhone4S",ModelNumber="I102",MemoryCard=16},
             new Mobile{Provider="Apple",ModelName="IPhone5",ModelNumber="I103",MemoryCard=32},
             new Mobile{Provider="Samsung",ModelName="GalaxyS",ModelNumber="S001",MemoryCard=4},
             new Mobile{Provider="Samsung",ModelName="GalaxyS2",ModelNumber="S002",MemoryCard=16},
             new Mobile{Provider="Samsung",ModelName="GalaxyS3",ModelNumber="S003",MemoryCard=20},
             new Mobile{Provider="Samsung",ModelName="Grand",ModelNumber="G001",MemoryCard=4},
             new Mobile{Provider="Nokia",ModelName="LUMIA530",ModelNumber="N1",MemoryCard=8},
             new Mobile{Provider="Nokia",ModelName="LUMIA730",ModelNumber="N2",MemoryCard=16},
             new Mobile{Provider="Nokia",ModelName="LUMIA930",ModelNumber="N3",MemoryCard=20},

            };

            var resultSet = from mobile in objMobileCollection
                            group mobile by new { mobile.Provider } into mGroup
                            orderby mGroup.Key.Provider
                            select new
                            {
                                Provider = mGroup.Key.Provider,
                                ModelName = mGroup.OrderBy(x => x.ModelName),
                                //ModelNumber = mGroup.OrderBy(x => x.ModelNumber),
                                //MemoryCard = mGroup.OrderBy(x => x.MemoryCard),
                            };

            foreach (var items in resultSet)
            {
                Console.WriteLine("{0} - {1}", items.Provider, items.ModelName.Count());
                Console.WriteLine("------------------------------------------------");
                foreach (var item in items.ModelName)
                {
                    Console.WriteLine(item.Provider + "\t" + item.ModelName + "\t\t" + item.ModelNumber.Trim() + "\t" + item.MemoryCard);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            /////////////Var Keyword uses


            //var resultSetLet = (from mobile in objMobileCollection
            //                    group mobile by new { mobile.Provider } into mGroup
            //                    //orderby mGroup.Key.Provider,mGroup.Key.MemoryCard
            //                    let avgMemory = mGroup.Sum(x => x.MemoryCard) / mGroup.Count()
            //                    where avgMemory > 11
            //                    select new
            //                    {
            //                        Provider = mGroup.GroupBy(x => x.Provider),
            //                        ModelName = mGroup.OrderBy(m => m.ModelName),
            //                        ModelNumber = mGroup.OrderBy(x => x.ModelNumber)
            //                        //MemoryCard = mGroup.OrderBy(x => x.MemoryCard),
            //                    }).ToList();

            //foreach (var items in resultSetLet)
            //{
            //    Console.WriteLine("{0} - {1}", items.Provider, items.ModelNumber.Count());
            //    Console.WriteLine("------------------------------------------------");
            //    foreach (var item in items.ModelNumber)
            //    {
            //        Console.WriteLine(item.Provider + "\t" + item.ModelName + "\t\t" + item.ModelNumber + "\t" + item.MemoryCard);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            //var objresult = from emp in objEmployee
            //                let totalSalary = objEmployee.Sum(sal => sal.Salary)
            //                let avgSalary = totalSalary / 5
            //                where avgSalary > emp.Salary
            //                select emp;

            #region Commented
            //string name = "Sachin Kalia from Roorkee";
            //int strIndex = name.IndexOf("Kalia");
            //string final = name.Substring(strIndex + 6, name.IndexOf("Roorkee") -strIndex -6);
            //   DateTime check = DateTimeOffset.Parse(DateTime.Now.ToShortDateString()).UtcDateTime;

            //int EVENTVALIDATIONIndex = JSStr.IndexOf("__EVENTVALIDATION") + 17;
            //EVENTVALIDATION = JSStr.Substring(EVENTVALIDATIONIndex + 32, JSStr.IndexOf("tableMast") - EVENTVALIDATIONIndex - 435);
            //Object Initialization for Employee class
            //List<Employee> objEmployee = new List<Employee>{
            //        new Employee{ Name="Sachin",EmpID="I001",Salary=800},
            //        new Employee{ Name="Vijay",EmpID="I002",Salary=400},
            //        new Employee{ Name="Ashish",EmpID="I003",Salary=250},
            //        new Employee{ Name="Syed",EmpID="I004",Salary=300},
            //        new Employee{ Name="Ravish",EmpID="I005",Salary=700},
            //    };           

            //var objresult = from emp in objEmployee
            //                let totalSalary = objEmployee.Sum(sal => sal.Salary)
            //                let avgSalary = totalSalary / 5
            //                where avgSalary > emp.Salary
            //                select emp;
            //foreach (var emp in objresult)
            //{
            //    Console.WriteLine("Student: {0} {1}", emp.Name, emp.EmpID);

            //}
            //Console.ReadLine();
            #endregion Commented
        }
    }
}
