// See https://aka.ms/new-console-template for more information
using adapter_pattern.Adapter;
using adapter_pattern.LegacyStuff;

Console.WriteLine("Hello, World!");

FootballerProvider FootballerProvider = new();
ITarget target = new FootballerAdapter(FootballerProvider);
var footballers = target.Footballers();

foreach (var footballer in footballers)
{
    Console.WriteLine($"Footballer Name:{footballer.Name}");
    Console.WriteLine($"Footballer Team:{footballer.Team}");
    Console.WriteLine($"Footballer Birth Date:{footballer.BirthDate.ToShortDateString()}");
    Console.WriteLine($"Footballer Position:{footballer.Position}");
}