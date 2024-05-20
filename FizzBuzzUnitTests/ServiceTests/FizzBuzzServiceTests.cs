using FizzBuzzTest.Services;

namespace FizzBuzzUnitTests.ServiceTests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        [DataRow(9)]
        [DataRow(18)]
        [DataRow(27)]
        public void Process_ShouldReturnFizzWord_WhenPassedValuesDivisableByThree(int number)
        {
            // Arrange
            var expectedResult = "Fizz";

            // Act
            var actualResult = _fizzBuzzService.Process(number);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(25)]
        public void Process_ShouldReturnBuzzWord_WhenPassedFive(int number)
        {
            // Arrange
            var expectedResult = "Buzz";

            // Act
            var actualResult = _fizzBuzzService.Process(number);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        public void Process_ShouldReturnFizzbuzzWord_WhenPassedNinety(int number)
        {
            // Arrange
            var expectedResult = "Fizzbuzz";

            // Act
            var actualResult = _fizzBuzzService.Process(number);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
