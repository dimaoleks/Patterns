using Composite.Abstractions;

namespace Composite.Equipments;

public class Tools : Equipment
{
    public Tools(string name, decimal price)
    {
        SetName($"Tools {name}");
        SetPrice(price);
    }
}
