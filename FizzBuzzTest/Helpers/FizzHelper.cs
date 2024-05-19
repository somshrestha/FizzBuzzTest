namespace FizzBuzzTest.Helpers
{
    public class FizzHelper : IFizzBuzzRule
    {
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
