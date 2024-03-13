using Proxy.Abstractions;

namespace Proxy;

public class RealCar : ICar
{
    private readonly string _model;

    public RealCar(string model)
    {
        _model = model;
        LoadFromDatabase();
    }

    public void Drive()
        => Console.WriteLine($"{_model} car is driving");

    private void LoadFromDatabase()
        => Console.WriteLine("Loading cars from the database");
}
