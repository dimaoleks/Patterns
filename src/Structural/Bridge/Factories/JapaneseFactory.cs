using Bridge.Abstractions;
using Bridge.Cars;

namespace Bridge.Factories;

public sealed class JapaneseFactory : CarFactory
{
    public override ICar Manufacture() => new JapaneseCar();
}
