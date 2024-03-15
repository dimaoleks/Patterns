using Proxy;
using Proxy.Abstractions;

ICarDb carDbProxy = new CarProxy(new CarDatabase());

while (true)
{
    Thread.Sleep(2000);

    Console.Clear();

    var cars = carDbProxy.GetCars();

    foreach (var car in cars)
    {
        Console.WriteLine($"Car name: {car.Name} \t\t Price: {car.Price} $");
    }
}
