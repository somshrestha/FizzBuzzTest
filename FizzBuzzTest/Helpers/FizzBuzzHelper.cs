namespace FizzBuzzTest.Helpers
{
    public class FizzBuzzHelper : IFizzBuzzRule
    {
        public bool IsMatch(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public string GetResult()
        {
            return "Fizzbuzz";
        }
    }
}
