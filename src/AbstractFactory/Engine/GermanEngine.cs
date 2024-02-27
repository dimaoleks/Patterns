using AbstractFactory.Abstractions;

namespace AbstractFactory.Engine;

internal sealed class GermanEngine : IEngine
{
    public void Release()
        => Console.WriteLine("Released German Engine");
}
