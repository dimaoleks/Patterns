using Composite.Abstractions;

namespace Composite.Equipments;
public class Body : Equipment
{
    public Body(string name, decimal price)
    {
        SetName($"Body {name}");
        SetPrice(price);
    }
}
