using ChainOfResponsibility.Abstractions;
using System.Transactions;

namespace ChainOfResponsibility;

public class ElectricWorker : BaseWorker
{
    public override bool Handle(string command)
    {
        if (command.Equals("Electric", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Electricity is repairing");
            return true;
        }

        Console.WriteLine("Electricity is okay");
        return base.Handle(command);
    }
}
