using Flyweight.Abstractions;

namespace Flyweight.Factory;
public class FlyweightFactory
{
    private readonly IDictionary<string, ICar> _values = new Dictionary<string, ICar>();

    public ICar GetOrCreateCar(string key)
    {
        if (_values.TryGetValue(key, out ICar? value))
        {
            return value;
        }

        var car = new Car(key);

        _values.Add(key, car);

        return car;
    }
}
