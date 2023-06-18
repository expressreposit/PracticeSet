using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImpPractical
{
    //  Thread are core affinity which are divide the task parallely for each cpu core on machine.
    class TaskParallelLibrary
    {
        static void Main1(string[] args)
        {
            //Thread t1 = new Thread(RunMillionIteration);
            //t1.Start();
            //  IMP:    TPL(Task Parallel Library) encapsulates multi-core execution.
            Parallel.For(0, 1000000, x => RunMillionIteration());
            Console.ReadLine();
        }

        private static void RunMillionIteration()
        {
            string x = "";
            for(int iIndex=0;iIndex<1000000;iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
