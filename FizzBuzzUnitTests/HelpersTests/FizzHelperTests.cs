using FizzBuzzTest.Helpers;

namespace FizzBuzzUnitTests.HelpersTests
{
    [TestClass]
    public class FizzHelperTests
    {
        private readonly FizzHelper _fizzHelper;

        public FizzHelperTests()
        {
            _fizzHelper = new FizzHelper();
        }

        [TestMethod]
        public void IsMatch_ShouldReturnTrue_WhenTheNumberPassedIsDivisibleByThree()
        {
            // Arrange
            var expectedResult = true;

            // Act
            var actualResult = _fizzHelper.IsMatch(9);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetResult_ShouldReturnFizzWord_WhenTheNumberPassedIsDivisibleByThree()
        {
            // Arrange
            var expectedResult = "Fizz";

            // Act
            var actualResult = _fizzHelper.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divisable_ShouldReturn_Three()
        {
            // Arrange
            var expectedResult = 3;

            // Act
            var actualResult = _fizzHelper.DivisableBy;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
