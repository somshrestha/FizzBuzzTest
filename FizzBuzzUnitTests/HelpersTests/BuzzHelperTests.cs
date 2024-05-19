using FizzBuzzTest.Helpers;

namespace FizzBuzzUnitTests.HelpersTests
{
    [TestClass]
    public class BuzzHelperTests
    {
        private readonly BuzzHelper _buzzHelper;

        public BuzzHelperTests()
        {
            _buzzHelper = new BuzzHelper();
        }

        [TestMethod]
        public void IsMatch_ShouldReturnTrue_WhenTheNumberPassedIsDivisibleByFive()
        {
            // Arrange
            var expectedResult = true;

            // Act
            var actualResult = _buzzHelper.IsMatch(10);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetResult_ShouldReturnBuzzWord_WhenTheNumberPassedIsDivisibleByFive()
        {
            // Arrange
            var expectedResult = "Buzz";

            // Act
            var actualResult = _buzzHelper.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Divisable_ShouldReturn_Five()
        {
            // Arrange
            var expectedResult = 5;

            // Act
            var actualResult = _buzzHelper.DivisableBy;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
