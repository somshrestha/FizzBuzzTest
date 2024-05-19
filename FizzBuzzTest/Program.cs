// See https://aka.ms/new-console-template for more information
using FizzBuzzTest.Services;

Console.WriteLine("Hello, World!");

var fizzbuzzService = new FizzBuzzLoaderService();

var rules = fizzbuzzService.LoadRules();
var processor = new FizzBuzzService(rules);

for (int i = 1; i < 100; i++)
{
    Console.WriteLine(processor.Process(i));
}

