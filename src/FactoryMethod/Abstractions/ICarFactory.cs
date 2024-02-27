namespace FactoryMethod.Abstractions;
public interface ICarFactory
{
    TProduct Create<TProduct>() where TProduct : ICar, new();
}
