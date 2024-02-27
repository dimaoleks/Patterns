using FactoryMethod.Abstractions;

namespace FactoryMethod;
internal class BMW : ICar
{
    public decimal Price => 5;

    public void ShowPrice()
    {
        Console.WriteLine($"BMW: price = {Price}");
    }
}
