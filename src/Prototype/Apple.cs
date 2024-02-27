using Prototype.Abstractions;

namespace Prototype;

internal sealed class Apple(Characteristic characteristic) : IFruit
{
    public Characteristic Characteristic { get; set; } = characteristic;

    public IFruit ShallowClone() => (Apple)MemberwiseClone();

    public IFruit DeepClone()
    {
        var clone = (Apple)MemberwiseClone();
        clone.Characteristic = new(Characteristic);

        return clone;
    }
}
