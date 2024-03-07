using Bridge.Abstractions;
using Bridge.Cars;

namespace Bridge.Factories;
public sealed class GermanFactory : CarFactory
{
    public override ICar Manufacture() => new GermanCar();
}
