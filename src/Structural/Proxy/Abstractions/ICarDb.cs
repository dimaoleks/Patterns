namespace Proxy.Abstractions;

public interface ICarDb
{
    public IEnumerable<ICar> GetCars();
}
