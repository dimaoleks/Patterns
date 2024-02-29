using FactoryMethod.Abstractions;

namespace FactoryMethod;

internal class Audi : ICar
{
    public decimal Price => 10;

    public void ShowPrice()
    {
        Console.WriteLine($"Audi: price = {Price}");
    }
}
