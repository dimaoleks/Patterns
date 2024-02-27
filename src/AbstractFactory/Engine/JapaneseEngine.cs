using AbstractFactory.Abstractions;

namespace AbstractFactory.Engine;

internal sealed class JapaneseEngine : IEngine
{
    public void Release()
        => Console.WriteLine("Released Japanese Engine");
}
