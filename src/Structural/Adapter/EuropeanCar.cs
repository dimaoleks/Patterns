using Adapter.Abstractions;

namespace Adapter;

public class EuropeanCar(float speed) : ICar
{
    public float GetSpeed()
        => speed;
}
