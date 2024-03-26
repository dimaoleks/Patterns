namespace ChainOfResponsibility.Abstractions;

public interface IWorker
{
    IWorker SetNext(IWorker worker);
    bool Handle(string command);
}
