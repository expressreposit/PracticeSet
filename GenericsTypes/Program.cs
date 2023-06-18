using System;

namespace GenericsTypes
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("----------------------------------------------Generics Types");
            //integer type generic
            GenericsType<int> objintGen = new GenericsType<int>(20);
            objintGen.input();

            //string type generic
            GenericsType<string> objstrGen = new GenericsType<string>("AmitKH");
            objstrGen.input();
            
            Console.ReadLine();
        }
    }
}
