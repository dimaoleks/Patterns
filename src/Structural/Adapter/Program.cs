using Adapter;
using Adapter.Abstractions;

ICar europeanCar = new EuropeanCar(130f);
ICar americanCar = new AmericanCarAdapter(130f);

Console.WriteLine($"Speed of european car in km/h: {europeanCar.GetSpeed()}");
Console.WriteLine($"Speed of american car in miles/h: {americanCar.GetSpeed()}");

Console.WriteLine();