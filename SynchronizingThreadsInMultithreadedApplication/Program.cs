//using System.Runtime.Remoting.Contexts;
public class Program
{
    //To illustrate the problem of concurrency let us write some line of code.
    private static void Main(string[] args)
    {
        Console.WriteLine("----Synchronnization of Threads-----");
        Console.WriteLine("Main Thread {0}", Thread.CurrentThread.ManagedThreadId);

        Printer p = new Printer();
        Thread[] threads = new Thread[5]; 

        //Queue for 5 Threads
        for(int i=0; i<5;i++)
        {
            threads[i] = new Thread(new ThreadStart(p.PrintNumbersSync));
        }
        foreach (Thread t in threads)
        {
            t.Start();
        }
        Console.ReadLine();
    }
}

public class Printer
{
    private Object ThreadLock = new object();
    public void PrintNumbersNonSync()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Executing Thread {0}", Thread.CurrentThread.ManagedThreadId);
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
    }
    public void PrintNumbersSynchronized()
    {
        //Syncronization Thread
        lock(ThreadLock)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Executing Thread {0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
        }
    }

    public void PrintNumbersSync()
    {
        Monitor.Enter(ThreadLock);
        int intVal=0;
        int newVal = Interlocked.Increment(ref intVal);
        try
        {
            intVal++;
            Console.WriteLine(" ");
            Console.WriteLine("Executing Thread {0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
        }
        finally
        {
            Monitor.Exit(ThreadLock);
        }
    }
}