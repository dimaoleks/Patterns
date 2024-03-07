namespace Composite.Abstractions;

public abstract class Equipment
{
    protected decimal Price { get; private set; }
    protected string Name { get; private set; } = null!;

    public virtual decimal GetPrice()
        => Price;

    public void SetPrice(decimal price)
        => Price = price;

    public virtual string GetName()
        => Name;

    public void SetName(string name)
        => Name = name;
}
