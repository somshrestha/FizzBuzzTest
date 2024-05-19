namespace FizzBuzzTest.Interfaces
{
    public interface IFizzBuzzRule
    {
        int DivisableBy { get; }
        bool IsMatch(int number);
        string GetResult();
    }
}
