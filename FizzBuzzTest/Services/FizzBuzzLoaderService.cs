using FizzBuzzTest.Interfaces;
using System.Reflection;

namespace FizzBuzzTest.Services
{
    public class FizzBuzzLoaderService
    {
        public IEnumerable<IFizzBuzzRule> LoadRules()
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
