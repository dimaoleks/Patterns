using Proxy.Abstractions;

namespace Proxy;

public class Car(string model) : ICar
{
    private readonly string _model = model;

    public string Name => _model;

    public decimal Price => new Random().Next(50000, 90000);

    public void Drive()
        => Console.WriteLine($"{_model} car is driving");
}
