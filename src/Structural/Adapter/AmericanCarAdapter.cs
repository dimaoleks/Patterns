using Adapter.Abstractions;

namespace Adapter;
public class AmericanCarAdapter(float speed) : AmericanCar(speed), ICar
{
    float ICar.GetSpeed()
        => (GetSpeed() / 1.61F);
}
