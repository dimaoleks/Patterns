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

        _values.Add(key, new Car(key));

        return _values[key];
    }
}
