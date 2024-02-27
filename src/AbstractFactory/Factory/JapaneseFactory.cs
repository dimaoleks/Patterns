using AbstractFactory.Abstractions;
using AbstractFactory.Cars;
using AbstractFactory.Engine;

namespace AbstractFactory.Factory;

internal class JapaneseFactory : IFactory
{
    public ICar CreateCar()
        => new Toyota();

    public IEngine CreateEngine()
        => new JapaneseEngine();
}
