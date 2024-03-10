using Facade;
using Facade.Abstractions;

ICar carFacade = new CarFacade();


Console.WriteLine("============= PREPARING... ============");
carFacade.Prepare();
Console.WriteLine("============= END OF PREPARING... ============");

Console.WriteLine("============= STARTING... ============");
carFacade.Start();
Console.WriteLine("============= END OF STARTING... ============");


carFacade.Go();