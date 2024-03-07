using Bridge.Abstractions;

namespace Bridge.Cars;

public sealed class GermanCar : ICar
{
    public void Go()
        => Console.WriteLine("German car go!!!");
}
