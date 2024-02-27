using AbstractFactory.Abstractions;

namespace AbstractFactory.Cars;
internal sealed class Toyota : ICar
{
    public void Release(IEngine engine)
    {
        Console.WriteLine("Toyota has been released");

        engine.Release();
    }
}
