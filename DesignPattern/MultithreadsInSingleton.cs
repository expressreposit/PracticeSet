using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MultithreadsInSingleton   //Thread safety in singleton pattern.
    {
        static void Main1(string[] args)
        {
            Parallel.Invoke(() => PrintEmployeeDetails(), () => PrintStudentDetails());

            Console.ReadLine();
        }
        private static void PrintStudentDetails()
        {
            //  Assuming Singleton is created from Student class
            //  we refer to the GetInstance property from the Singleton class
            NewSingletons fromStudent = NewSingletons.GetInstance;
            fromStudent.printDetails("This is second message");
        }
        private static void PrintEmployeeDetails()
        {
            //  Assuming Singleton is created from employee class
            //  we refer to the GetInstance property from the Singleton class
          NewSingletons fromEmployee = NewSingletons.GetInstance;
            fromEmployee.printDetails("This is first message");
        }
    }
    public sealed class NewSingletons   // Sealed restricts the inheritance
    {
        private static int counter = 0;
        private static NewSingletons instance = null;
        private static readonly object obj = new object();
        public static NewSingletons GetInstance //  public property is used to return only one instance of the class leveraging on the private property
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new NewSingletons();
                    }
                }
                return instance;
            }
        }
        private NewSingletons() //Private constructor ensures that object is not instantiated other than with in the class itself
        {
            counter++;
            Console.WriteLine("counter Value " + counter.ToString());
        }
        public void printDetails(string message)    //Public method which can be invoked through the singleton instance
        {
            Console.WriteLine(message);
        }
    }
}
