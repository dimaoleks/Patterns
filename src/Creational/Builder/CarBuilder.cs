using Builder.Abstractions;
using Builder.Parts;

namespace Builder;

internal sealed class CarBuilder : ICarBuilder<Car>
{
    private Car _car;

    public CarBuilder() => _car = new();

    public ICarBuilder<Car> AddDoor()
    {
        _car.Doors.Add(new Door());
        return this;
    }

    public ICarBuilder<Car> AddEngine()
    {
        _car.Engine = new Engine();
        return this;
    }

    public ICarBuilder<Car> AddWheel()
    {
        _car.Wheels.Add(new Wheel());
        return this;
    }

    public Car Build() => _car;
}
