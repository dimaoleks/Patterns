using Proxy.Abstractions;

namespace Proxy;

public sealed class CarDatabase : ICarDb
{
    public IEnumerable<ICar> GetCars()
        => new List<Car>
        {
            new("Audi"),
            new("BMW"),
            new("Mercedes"),
            new("Toyota"),
        };

}
