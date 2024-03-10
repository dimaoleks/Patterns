namespace Facade;

public class HandBrake
{
    public void Check()
        => Console.WriteLine("Check HandBrake");

    public void Enable()
        => Console.WriteLine("HandBrake is enabled");

    public void Disable()
        => Console.WriteLine("HandBrake is disabled");
}
