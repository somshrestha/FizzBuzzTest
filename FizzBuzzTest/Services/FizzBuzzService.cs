using FizzBuzzTest.Interfaces;
using System.Reflection;

namespace FizzBuzzTest.Services
{
    public class FizzBuzzService
    {
        private readonly IEnumerable<IFizzBuzzRule> _fizzBuzzRules;

        public FizzBuzzService(IEnumerable<IFizzBuzzRule> rules)
        {
            _fizzBuzzRules = rules;
        }

        public string Process(int number)
        {
            foreach (var rule in _fizzBuzzRules)
            {
                var isMatch = rule.IsMatch(number);

                if (isMatch)
                {
                    return rule.GetResult();
                }
            }
            return number.ToString();
        }
    }
}
