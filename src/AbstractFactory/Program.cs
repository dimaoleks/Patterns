using AbstractFactory.Abstractions;
using AbstractFactory.Factory;

Console.WriteLine("######## JAPANESE CAR ########");
Console.WriteLine("##############################");
Console.WriteLine();

IFactory jFactory = new JapaneseFactory();

IEngine jEngine = jFactory.CreateEngine();
ICar jCar = jFactory.CreateCar();

jCar.Release(jEngine);

Console.WriteLine();
Console.WriteLine("######## JAPANESE CAR ########");
Console.WriteLine("##############################");
Console.WriteLine();

Console.WriteLine("==============================");

Console.WriteLine();
Console.WriteLine("######### GERMAN CAR #########");
Console.WriteLine("##############################");
Console.WriteLine();

IFactory gFactory = new GermanFactory();

IEngine gEngine = gFactory.CreateEngine();
ICar gCar = gFactory.CreateCar();

gCar.Release(gEngine);

Console.WriteLine();
Console.WriteLine("######### GERMAN CAR #########");
Console.WriteLine("##############################");