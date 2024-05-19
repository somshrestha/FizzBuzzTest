using FizzBuzzTest.Helpers;

namespace FizzBuzzUnitTests.HelpersTests
{
    [TestClass]
    public class FizzBuzzHelperTests
    {
        private readonly FizzBuzzHelper _fizzBuzzHelper;

        public FizzBuzzHelperTests()
        {
            _fizzBuzzHelper = new FizzBuzzHelper();
        }
        [TestMethod]
        public void IsMatch_ShouldReturnTrue_WhenTheNumberPassedIsDivisibleByThreeAndFive()
        {
            // Arrange
            var expectedResult = true;

            // Act
            var actualResult = _fizzBuzzHelper.IsMatch(30);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetResult_ShouldReturnBuzzWord_WhenTheNumberPassedIsDivisibleByThreeAndFive()
        {
            // Arrange
            var expectedResult = "Fizzbuzz";

            // Act
            var actualResult = _fizzBuzzHelper.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
