namespace FizzBuzzTest
{
    public interface IFizzBuzzRule
    {
        bool IsMatch(int number);
        string GetResult();
    }
}
