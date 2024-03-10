using Decorator.Abstractions;

namespace Decorator.Cars;

public class BasicCar : ICar
{
    public void Assemble()
    {
        Console.WriteLine("Basic Car is assembled");
    }
}
