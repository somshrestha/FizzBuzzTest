using FizzBuzzTest.Interfaces;
using System.Reflection;

namespace FizzBuzzTest.Services
{
    public class FizzBuzzService
    {

        public string Process(int number)
        {
            var fizzBuzzRules = this.LoadRules();
            foreach (var rule in fizzBuzzRules)
            {
                var isMatch = rule.IsMatch(number);

                if (isMatch)
                {
                    return rule.GetResult();
                }
            }
            return number.ToString();
        }

        private IEnumerable<IFizzBuzzRule> LoadRules()
        {
            var rules = Assembly.GetExecutingAssembly().GetTypes()
                                    .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && !t.IsInterface)
                                    .Select(rt => (IFizzBuzzRule)Activator.CreateInstance(rt))
                                    .OrderByDescending(rt => rt.DivisableBy)
                                    .ToList();

            return rules;
        }
    }
}
