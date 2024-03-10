using Decorator.Abstractions;

namespace Decorator;
public class CarDecorator(ICar _carDecorator) : ICar
{
    public virtual void Assemble()
    {
        _carDecorator.Assemble();
    }
}
