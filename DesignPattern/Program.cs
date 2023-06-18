using System;

namespace DesignPattern
{
    class Program
    {
        static void Main1(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.printDetails("This is first message");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.printDetails("This is second message");

            Console.ReadLine();
        }
    }
    public sealed class Singleton
    {
        private Singleton()
        {
            counter++;
            Console.WriteLine("counter Value " + counter.ToString());
        }
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
       
        public void printDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
