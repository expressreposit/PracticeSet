using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImpPractical
{
    //  Asynch and Await are markers which code position d=from control should resume ag=fter a task(thread) completes. 
    class AsyncAndAwait    // Introduce in .Net 4.5 framework.
    {
        static void Main1(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
        public static  async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");    // this line execute, Wait until the long task finishes.
        }
        public static void LongTask()
        {
            Thread.Sleep(20000);
            Console.WriteLine("New Thread of LongTask");
        }
    }
}               
            /*  output
            Main Thread
            New Thread of LongTask
            New Thread
             */
