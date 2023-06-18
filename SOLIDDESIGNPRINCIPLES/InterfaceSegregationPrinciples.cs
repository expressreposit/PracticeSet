using System;
using System.Collections.Generic;
using System.Text;
/*
        The interface-segregation principle (ISP) states that "no client should be forced to depend on methods it does not use".
        This means, instead of one fat interface many small interfaces are preferred based on groups of methods with each one serving one sub-module.
        The ISP was first used and formulated by Robert C. Martin while consulting for Xerox.
 */
namespace SOLIDDESIGNPRINCIPLES
{
    class InterfaceSegregationPrinciples
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IPrintScanContent    //  Big fat interface segregate into split into many small interface
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
        //bool FaxContent(string content);
        //bool PrintDuplexContent(string content);    //This function required to CannonMG2470 only not for HP
    }
    interface IFaxContent
    {
        bool FaxContent(string content);
    }
    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
    class HPlaserJet : IPrintScanContent, IFaxContent    //Client Class
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done");
            return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photo Copy Done");
            return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
    class CannonMG2470 : IPrintScanContent, IPrintDuplex        //But this cannon print class do not all require all interface function, it's force to implement 
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photo Copy Done");
            return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
