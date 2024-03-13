using Flyweight.Abstractions;

namespace Flyweight;

public sealed class Car(string name) : ICar
{
    private readonly string _name = name;

    public void Drive() => Console.WriteLine($"{_name} is driving");
}
