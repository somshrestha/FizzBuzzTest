using FizzBuzzTest.Interfaces;

namespace FizzBuzzTest.Helpers
{
    public class FizzHelper : IFizzBuzzRule
    {
        public int DivisableBy => 3;

        public bool IsMatch(int number)
        {
            return number % 3 == 0;
        }

        public string GetResult()
        {
            return "Fizz";
        }
    }
}
