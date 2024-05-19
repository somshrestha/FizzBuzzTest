using FizzBuzzTest.Interfaces;

namespace FizzBuzzTest.Helpers
{
    public class BuzzHelper : IFizzBuzzRule
    {
        public int DivisableBy => 5;

        public bool IsMatch(int number)
        {
            return number % 5 == 0;
        }

        public string GetResult()
        {
            return "Buzz";
        }

    }
}
