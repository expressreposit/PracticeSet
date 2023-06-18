using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTypes
{
    public class ProgramStruct
    {
        public struct Student
        {
            public int Id;
            public string Name;
            public double Age;
            public Student(int id, string name, double age)
            {
                this.Id = id;
                this.Name = name;
                this.Age = age;
            }
            public void DisplayValues()
            {
                Console.WriteLine("Id " + this.Id);
                Console.WriteLine("Name " + this.Name);
                Console.WriteLine("Age " + this.Age);
            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("------Struct");
            ProgramStruct.Student objstruct = new ProgramStruct.Student(10, "amit", 37);
            objstruct.DisplayValues();
            Console.WriteLine("--------Struct Using lnterface");
            StructUsinglnterface.Ii objstructI = new StructUsinglnterface.Ii.Students(101, "amit khobragade", 38);
            objstructI.Displayvalues();

            Console.ReadLine();
        }
    }
    public class StructUsinglnterface
    {
        public interface Ii
        {
            void Displayvalues();
            public struct Students : Ii //  struct implement Interface
            {
                int Id;
                string Name;
                int Age;
                public Students(int Id, string Name, int Age)
                {
                    this.Id = Id;
                    this.Name = Name;
                    this.Age = Age;
                }
                public void Displayvalues()
                {
                    Console.WriteLine("Id: " + this.Id.ToString());
                    Console.WriteLine("Name : " + this.Name.ToString());
                    Console.WriteLine("Age : " + this.Age.ToString());
                }
            }
        }
    }
}
