namespace Builder.Abstractions;

public interface ICarBuilder<T>
{
    ICarBuilder<T> AddWheel();
    ICarBuilder<T> AddDoor();
    ICarBuilder<T> AddEngine();
    T Build();
}
