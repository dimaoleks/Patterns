using System.Drawing;

namespace Prototype;

public sealed class Characteristic
{
    public double Weight { get; init; }
    public Color Color { get; init; }

    public Characteristic(double weight, Color color)
        => (Weight, Color) = (weight, color);

    public Characteristic(Characteristic characteristic)
      => (Weight, Color) = (characteristic.Weight, characteristic.Color);
}
