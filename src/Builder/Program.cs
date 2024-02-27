using Builder;
using Builder.Abstractions;

ICarBuilder<Car> carBuilder = new CarBuilder();

Car car = carBuilder.AddEngine()
    .AddDoor()
    .AddWheel()
    .Build();

Console.WriteLine($"Car has engine: {car.Engine is not null}, wheels: {car.Wheels.Count}, doors: {car.Doors.Count}");