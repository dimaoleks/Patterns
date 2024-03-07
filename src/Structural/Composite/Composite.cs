using Composite.Abstractions;

namespace Composite;

public class Composite : Equipment
{
    private readonly List<Equipment> _equipment = [];

    public void AddEquipment(Equipment eq)
        => _equipment.Add(eq);

    public void AddEquipment(params Equipment[] eq)
        => _equipment.AddRange(eq);

    public override decimal GetPrice()
        => _equipment.Sum(e => e.GetPrice());

    public void DisplayInfo()
    {
        _equipment.ForEach(e => Console.WriteLine($"Item: {e.GetName()}"));

        Console.WriteLine();

        Console.Write($"Total Price: {GetPrice()}");
    }
}
