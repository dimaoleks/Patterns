using Flyweight.Abstractions;
using Flyweight.Factory;

FlyweightFactory flyweightFactory = new ();

ICar bmwCar = flyweightFactory.GetOrCreateCar("BMW");
ICar audiCar = flyweightFactory.GetOrCreateCar("Audi");
ICar volkswagenCar = flyweightFactory.GetOrCreateCar("Volkswagen");

ICar teslaCar = flyweightFactory.GetOrCreateCar("Tesla");

ICar teslaCar2 = flyweightFactory.GetOrCreateCar("Tesla");

Console.WriteLine($"Tesla car1 and Tesla car2 is same object? - {teslaCar.Equals(teslaCar2)}");

Console.WriteLine($"CASE 2 Tesla car1 and Tesla car2 is same object? - {teslaCar ==teslaCar2}");


Console.WriteLine();