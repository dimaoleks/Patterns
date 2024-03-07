using Composite.Abstractions;

namespace Composite.Equipments;

public class Engine : Equipment
{
    public Engine(string name, decimal price)
    {
        SetName($"Engine {name}");
        SetPrice(price);
    }
}
