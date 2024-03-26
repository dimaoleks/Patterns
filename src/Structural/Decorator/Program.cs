using Decorator;
using Decorator.Abstractions;
using Decorator.Cars;

ICar basicCar = new BasicCar();

ICar sportsCar = new SportsCarDecorator(basicCar);
sportsCar.Assemble();

ICar luxuryCar = new LuxuryCarDecorator(basicCar);
luxuryCar.Assemble();
