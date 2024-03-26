using ChainOfResponsibility;
using ChainOfResponsibility.Abstractions;

IWorker worker = new BaseWorker();
worker.SetNext(new ElectricWorker())
    .SetNext(new BodyWorker())
    .SetNext(new EngineWorker());

worker.Handle("Body");
Console.WriteLine();

worker.Handle("Engine");
Console.WriteLine();

worker.Handle("Check brake");
Console.WriteLine();