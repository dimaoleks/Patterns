namespace ChainOfResponsibility.Abstractions;
public class BaseWorker : IWorker
{
    private IWorker? _nextHandler;

    public IWorker SetNext(IWorker handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual bool Handle(string command)
    {
        return _nextHandler?.Handle(command) is true;
    }
}
