using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestExample.Models;

namespace XUnitTestExample.Tests.MockServices
{
    public class MockEmailService : IEmailService
    {
        public bool isEmailAvailable()
        {
            return true;
        }

        public void SendEmail()
        {
            //
        }
    }
}
