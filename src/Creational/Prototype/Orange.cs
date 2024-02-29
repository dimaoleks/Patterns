using Prototype.Abstractions;

namespace Prototype;

internal sealed class Orange(Characteristic characteristic) : IFruit
{
    public Characteristic Characteristic { get; set; } = characteristic;

    public IFruit ShallowClone() => (Orange)MemberwiseClone();

    public IFruit DeepClone()
    {
        var clone = (Orange)MemberwiseClone();
        clone.Characteristic = new(Characteristic);

        return clone;
    }
}
