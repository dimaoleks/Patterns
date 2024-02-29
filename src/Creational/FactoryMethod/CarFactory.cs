using FactoryMethod.Abstractions;

namespace FactoryMethod;

public sealed class CarFactory : ICarFactory
{
    TProduct ICarFactory.Create<TProduct>()
    {
        return new TProduct();
    }
}
