namespace FizzBuzzTest.Helpers
{
    public class BuzzHelper : IFizzBuzzRule
    {
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
