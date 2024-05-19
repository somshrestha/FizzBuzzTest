using FizzBuzzTest.Interfaces;

namespace FizzBuzzTest.Helpers
{
    public class FizzBuzzHelper : IFizzBuzzRule
    {
        public int DivisableBy => 15;

        public bool IsMatch(int number)
        {
            return number % 15 == 0;
        }

        public string GetResult()
        {
            return "Fizzbuzz";
        }
    }
}
