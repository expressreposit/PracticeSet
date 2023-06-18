using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestExample.Controllers;

namespace XUnitTestExample.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
            //Add project Reference to compare the results.
            // AAA Methodology Arrange Action Assert.
            //Arrange
            HomeController homeController = new HomeController();
            string expectedResult = "I am in Home";

            //Act - Action
            string result = homeController.Index();

            //Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void HomeController_Index_ValidateLargeNumberGuessResult()
        {
            //Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 120;
            string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.Equal(epectedResult, result);
        }
        [Fact]
        public void HomeController_Index_ValidateLargeNumberGuessResults()
        {
            //Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 120;
            string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.Equal(epectedResult, result);
        }
    }

}
