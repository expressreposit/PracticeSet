namespace XUnitTestExample.Models
{
    public interface IPrinterService
    {
        bool isPrintAvailable();
        void Print(string msg);
    }
    public class PrinterService : IPrinterService
    {
        public void Print(string msg)
        {
            Console.WriteLine("Print");
        }

        public bool isPrintAvailable()
        {
            return true;
        }
    }

}
