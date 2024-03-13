using Proxy.Abstractions;

namespace Proxy;

public sealed class CarProxy : ICar
{
    private RealCar _realCar;
    private string _model;

    public CarProxy(string model)
    {
        _model = model;
    }

    public void Drive()
    {
        _realCar ??= new RealCar(_model);

        Console.WriteLine($"Proxy is controlling access to {_model} car");

        _realCar.Drive();
    }
}
