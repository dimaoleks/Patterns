using FactoryMethod;
using FactoryMethod.Abstractions;

ICarFactory carFactory = new CarFactory();

ICar car = carFactory.Create<Audi>();

car.ShowPrice();

car = carFactory.Create<BMW>();

car.ShowPrice();