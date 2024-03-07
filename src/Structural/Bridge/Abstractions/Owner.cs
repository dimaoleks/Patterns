namespace Bridge.Abstractions;

public sealed class Owner(CarFactory _factory)
{
    public void ChangeFactory(CarFactory factory)
        => _factory = factory;

    public ICar Do() => _factory.Manufacture();
}
