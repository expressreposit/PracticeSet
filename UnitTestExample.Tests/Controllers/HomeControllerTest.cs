using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestExample.Controllers;

namespace UnitTestExample.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeController_Index_ValidateResult()
        {
            // AAA methodoly to use test case
            //Arrange
            HomeController controller = new HomeController();
            string expectedResult = "I am in home";
            //Action
            string result = controller.Index();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //[DataRow(120, "Wrong! try a smaller number")]
        //[DataRow(80, "Wrong! try a bigger number")]
        //[DataRow(100, "You guessed correct number")]
        [DynamicData(nameof(CreateSource))]
        public void HomeController_Index_ValidateLargeNumberGuessResult(int guessedNumber, string epectedResult)
        {
            //Arrange
            bool isMethodCalled = true;
            HomeController controller = new HomeController();
            //int guessedNumber = 120;
            //string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.AreEqual(epectedResult, result);
            Assert.AreNotEqual(20, result);
            Assert.IsTrue(isMethodCalled);
            Assert.IsFalse(true);
            Assert.AreSame(epectedResult, result);
            Assert.IsInstanceOfType(result, typeof(string));
            Assert.IsNull(null);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HomeController_Index_ValidateLargeNumberGuessResult()
        {
            //Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 120;
            string epectedResult = "Wrong! try a smaller number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.AreEqual(epectedResult, result);
        }
        [TestMethod]
        public void HomeController_Index_ValidateSmallerNumberGuessResult()
        {
            //Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 80;
            string epectedResult = "Wrong! try a bigger number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.AreEqual(epectedResult, result);
        }
        [TestMethod]
        public void HomeController_Index_ValidateCorrectNumberGuessResult()
        {
            //Arrange
            HomeController controller = new HomeController();
            int guessedNumber = 100;
            string epectedResult = "You guessed correct number";

            //Action
            string result = controller.Index(guessedNumber);

            //Assert
            Assert.AreEqual(epectedResult, result);
        }

        private static IEnumerable<object[]> CreateSource
        {
            get
            {
                return new[]
                {
                    new object[]{120, "Wrong! try a smaller number" },
                    new object[]{ 80, "Wrong! try a bigger number" },
                    new object[]{ 100, "You guessed correct number" }
                };
            }
        }
    }
}
