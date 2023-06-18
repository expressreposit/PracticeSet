using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestExample.Controllers;
using XUnitTestExample.Models;
using XUnitTestExample.Tests.MockServices;

namespace XUnitTestExample.Tests.Controllers
{
    public class ContactControllerTest
    {
        [Fact]
        public void ContactController_Index_ValidateLargeNumberWithEmailPrintSerivceGuessResult()
        {
            //Arrange
            //IPrinterService printerService = new MockPrinterService();
            //IEmailService emailService = new MockEmailService();
            
            //Method modify
            Mock<IEmailService> emailMockService = new Mock<IEmailService>();
            emailMockService.Setup(e=>e.isEmailAvailable()).Returns(true);
            //verify the fake email service hit or not
            emailMockService.Setup(e => e.SendEmail()).Verifiable();

            Mock<IPrinterService> printerMockService = new Mock<IPrinterService>();
            printerMockService.Setup(p => p.isPrintAvailable()).Returns(true);           

            //Check with method parameter values check using Mock
            printerMockService.Setup(p => p.Print(It.IsAny<string>())).Verifiable();

            ContactController controller = new ContactController(printerMockService.Object, emailMockService.Object);
            int guessedNumber = 120;
            string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.Equal(epectedResult, result);
            emailMockService.Verify(x => x.SendEmail(), Times.Once);

            //Verify the method parameter value
            printerMockService.Verify(p => p.Print("Test with string parameter in method"), Times.Once);
        }
        [Fact]
        public void ContactController_Index_ValidateLargeNumberWithoutEmailPrintSerivceGuessResult()
        {
            //Arrange
            //IPrinterService printerService = new MockPrinterService();
            //IEmailService emailService = new MockEmailService();

            //Method modify
            Mock<IEmailService> emailMockService = new Mock<IEmailService>();
            emailMockService.Setup(e => e.isEmailAvailable()).Returns(false);
            
            //verify the fake email service hit or not
            emailMockService.Setup(e => e.SendEmail()).Verifiable();
            Mock<IPrinterService> printerMockService = new Mock<IPrinterService>();
            printerMockService.Setup(p => p.isPrintAvailable()).Returns(false);

            ContactController controller = new ContactController(printerMockService.Object, emailMockService.Object);
            int guessedNumber = 120;
            string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.Equal(epectedResult, result);
            //Check method that call how many time and we specify Never.
            emailMockService.Verify(e => e.SendEmail(), Times.Never);
        }
    }
}
