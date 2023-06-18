using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestExample.Models;

namespace XUnitTestExample.Tests.MockServices
{
    public class MockPrinterService : IPrinterService
    {
        public bool isPrintAvailable()
        {
            return true;
        }

        public void Print(string msg)
        {
            //
        }
    }
}
