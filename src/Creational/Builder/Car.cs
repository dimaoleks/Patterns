using Builder.Parts;

namespace Builder;
internal sealed class Car
{
    public List<Door> Doors { get; set; } = [];
    public List<Wheel> Wheels { get; set; } = [];
    public Engine Engine { get; set; } = null!;
}
