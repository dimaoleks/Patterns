using Proxy.Abstractions;

namespace Proxy;

public sealed class CarProxy(CarDatabase db) : ICarDb
{
    private readonly CarDatabase _db = db;

    private IEnumerable<ICar> _cars;

    public IEnumerable<ICar> GetCars()
    {
        _cars ??= _db.GetCars();
    
        return _cars;
    }
}
