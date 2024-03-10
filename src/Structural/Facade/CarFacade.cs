using Facade.Abstractions;

namespace Facade;

public class CarFacade : ICar
{
    private readonly Engine _engine;
    private readonly HandBrake _handBrake;
    private readonly Lights _lights;

    private bool _isReady;

    public CarFacade()
    {
        _engine = new Engine();
        _lights = new Lights();
        _handBrake = new HandBrake();
    }

    public void Prepare()
    {
        _engine.Check();
        _handBrake.Check();
        _lights.Check();
    }

    public void Start()
    {
        _engine.Start();
        _lights.Start();
        _handBrake.Disable();

        _isReady = true;
    }

    public void Go()
    {
        if (_isReady)
            Console.WriteLine("Car GO!!!");
    }
}
