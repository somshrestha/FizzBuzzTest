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
            var actualResult = _buzzHelper.IsMatch(8);

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
    }
}
