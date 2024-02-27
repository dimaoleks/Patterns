namespace AbstractFactory.Abstractions;
public interface IFactory
{
    IEngine CreateEngine();
    ICar CreateCar();
}
