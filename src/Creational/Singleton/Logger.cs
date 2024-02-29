namespace Singleton;
public sealed class Logger
{
    private static Logger _instance;

    private static readonly object _lock = new();

    public static Logger GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                _instance ??= new();
            }
        }

        return _instance;
    }

    public void Log(string message) => Console.WriteLine($"Singleton Execution: {message}");
}
