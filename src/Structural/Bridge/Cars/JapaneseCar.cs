using Bridge.Abstractions;

namespace Bridge.Cars;
public sealed class JapaneseCar : ICar
{
    public void Go()
        => Console.WriteLine("Japanese car go!!!");
}
