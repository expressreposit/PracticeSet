using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDDESIGNPRINCIPLES
{
    /*
        Definition : In object-oriented programming, the open/closed principle states that "software entities such as classes, 
        modules, functions, etc. should be open for extension, but closed for modification".
        Which means, any new functionality should be implemented by adding new classes, attributes and methods, instead of changing the current ones or existing ones.
        Bertrand Meyer is generally credited for having originated the term open/closed principle and 
        This Principle is considered by Bob Martin as "the most important principle of object-oriented design".
     */
    class OpenClosedPrinciples
    {
        static void Main1(string[] args)
        {
            Employee empPermanant = new PermanantEmployee() { ID = 1, Name = "Kajal" };
            empPermanant.CalculateBonus(100000);
            Employee empTemp = new TempEmployee() { ID = 2, Name = "Sejal" };
            empTemp.CalculateBonus(150000);

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",empPermanant.ToString(),empPermanant.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empTemp.ToString(),empTemp.CalculateBonus(150000).ToString()));

            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee() { }
        public Employee(int id,string name)
        {
            this.ID = id;this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
    }
    public class PermanantEmployee : Employee
    {
        public PermanantEmployee() { }
        public PermanantEmployee(int id,string name):base(id,name) { }
        
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
        
    }
    public class TempEmployee : Employee
    {
        public TempEmployee() { }
        public TempEmployee(int id,string name) : base(id, name) { }
        
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
