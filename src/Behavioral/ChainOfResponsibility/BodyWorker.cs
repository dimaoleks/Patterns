using ChainOfResponsibility.Abstractions;

namespace ChainOfResponsibility;

public class BodyWorker : BaseWorker
{
    public override bool Handle(string command)
    {
        if (command.Equals("Body", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("Body is repairing");
            return true;
        }

        Console.WriteLine("Body is okay");
        return base.Handle(command);
    }
}