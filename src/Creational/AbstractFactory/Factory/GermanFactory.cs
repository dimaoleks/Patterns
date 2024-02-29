using AbstractFactory.Abstractions;
using AbstractFactory.Cars;
using AbstractFactory.Engine;

namespace AbstractFactory.Factory;
internal sealed class GermanFactory : IFactory
{
    public ICar CreateCar()
        => new Audi();

    public IEngine CreateEngine()
        => new GermanEngine();
}
