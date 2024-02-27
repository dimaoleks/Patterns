using AbstractFactory.Abstractions;

namespace AbstractFactory.Cars;

internal sealed class Audi : ICar
{
    public void Release(IEngine engine)
    {
        Console.WriteLine("Audi has been released");

        engine.Release();
    }
}
