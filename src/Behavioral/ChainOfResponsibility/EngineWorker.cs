using ChainOfResponsibility.Abstractions;

namespace ChainOfResponsibility;

public class EngineWorker : BaseWorker
{
    public override bool Handle(string command)
    {
        if (command.Equals("Engine", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Engine is repairing");
            return true;
        }

        Console.WriteLine("Engine is okay");
        return base.Handle(command);
    }
}
