using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDDESIGNPRINCIPLES
{
    class LiskovSubstitutionPrinciple
    {
        static void Main(string[] args)
        {
            List<EmployeeA> employeeAs = new List<EmployeeA>();
            employeeAs.Add(new PermanantEmployeeA(1, "John"));
            employeeAs.Add(new TempEmployeeA(2, "Jason"));
            //Un Comment to see the error
            //employeeAs.Add(new ContractEmployee(3, "Mike"));
            foreach (var emp in employeeAs)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                emp.ToString(),
                emp.CalculateBonus(100000).ToString(),
                emp.GetMinimumSalary().ToString()));
            }
            Console.WriteLine();

            List<IEmployeeA> employeesOnly = new List<IEmployeeA>();

            employeesOnly.Add(new PermanantEmployeeA(1, "John"));
            employeesOnly.Add(new TempEmployeeA(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
    interface IEmployeeA
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
    interface IEmployeeABonus
    {
        decimal CalculateBonus(decimal salary);
    }
    public abstract class EmployeeA : IEmployeeA, IEmployeeABonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EmployeeA() { }
        public EmployeeA(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
        public abstract decimal GetMinimumSalary();
    }
    public class PermanantEmployeeA : EmployeeA
    {
        public PermanantEmployeeA() { }
        public PermanantEmployeeA(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 8000;
        }
    }
    public class TempEmployeeA : EmployeeA
    {
        public TempEmployeeA() { }
        public TempEmployeeA(int id, string name) : base(id, name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
        public override decimal GetMinimumSalary()
        {
            return 12000;
        }
    }

    public class ContractEmployee : IEmployeeA
    {
        public ContractEmployee() { }
        public ContractEmployee(int id, string name)
        {
            this.ID = id; 
            this.Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0} Name : {1}", this.ID, this.Name);
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
