using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class LazyVsEagerLoadingInSingleton
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
            LazySingletons fromStudent = LazySingletons.GetInstance;
            fromStudent.printDetails("This is second message");
        }
        private static void PrintEmployeeDetails()
        {
            //  Assuming Singleton is created from employee class
            //  we refer to the GetInstance property from the Singleton class
            LazySingletons fromEmployee = LazySingletons.GetInstance;
            fromEmployee.printDetails("This is first message");
        }
    }
    public sealed class LazySingletons   // Sealed restricts the inheritance
    {
        private static int counter = 0;
        private static readonly Lazy<LazySingletons> instance = new Lazy<LazySingletons> (()=>new LazySingletons());
        //private static readonly object obj = new object();
        public static LazySingletons GetInstance //  public property is used to return only one instance of the class leveraging on the private property
        {
            get
            {
                return instance.Value;
            }
        }
        private LazySingletons() //Private constructor ensures that object is not instantiated other than with in the class itself
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
