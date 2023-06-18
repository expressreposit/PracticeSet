using System;

namespace VenkatPractice
{
    class Program   // can you store different types array 
    {
        static void Main1(string[] args)
        {
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "string";

            Customer cust = new Customer();
            cust.ID = 99;
            cust.Name = "Amit";
            array[2] = cust;
            foreach(object obj in array)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
        public void Test(int a, int b)
        {
        }
    }
}
