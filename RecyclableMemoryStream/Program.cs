using Microsoft.IO;
using System.IO;
using System.Text;

public class Program
{
    private static readonly RecyclableMemoryStreamManager 
        recyclableMemoryStreamManager1 = new RecyclableMemoryStreamManager ();
    private static void Main(string[] args)
    {
        string data = "This is simple text message";
        var buffer = Encoding.ASCII.GetBytes(data);
        using(var memoryStream = recyclableMemoryStreamManager1.GetStream("High_Performance_Stream_Demo.Program.Main")) 
        {
            memoryStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine(memoryStream);
        }
        Console.WriteLine(""    + 0+ buffer.Length);
        int blockSize = 1024;
        int largeBufferMultiple = 1024 * 1024;
        int maximumBufferSize = 16 * largeBufferMultiple;
        int maximumFreeLargePoolBytes = maximumBufferSize * 4;
        int maximumFreeSmallPoolBytes = 250 * blockSize;
        var recyclableMemoryStreamManager = new RecyclableMemoryStreamManager(blockSize, largeBufferMultiple, maximumBufferSize);
        recyclableMemoryStreamManager.AggressiveBufferReturn = true;
        recyclableMemoryStreamManager.GenerateCallStacks = true;
        recyclableMemoryStreamManager.MaximumFreeLargePoolBytes = maximumFreeLargePoolBytes;
        recyclableMemoryStreamManager.MaximumFreeSmallPoolBytes = maximumFreeSmallPoolBytes;
        Console.WriteLine("------------");
        Console.WriteLine(recyclableMemoryStreamManager.MaximumFreeLargePoolBytes);
        Console.WriteLine(recyclableMemoryStreamManager.MaximumFreeSmallPoolBytes);
        Console.ReadLine();
    }
}
/*
Take advantage of Microsoft.IO.RecyclableMemoryStream to eliminate LOH allocations
and avoid memory fragmentation and memory leaks in your .NET Core applications.

RecyclableMemoryStream benefits
Microsoft.IO.RecyclableMemoryStream provides the following benefits:

Eliminates LOH allocations using pooled buffers.
Incurs far fewer generation 2 GCs and spends much less time pausing while a GC operation is in progress.
Avoids memory fragmentation and memory leaks.
Provides metrics that can be used for tracking and analyzing performance. 

Small pool – contains small buffers that are used in read/write operations
Large pool – contains large buffers used only when you have a contiguous buffer
*/