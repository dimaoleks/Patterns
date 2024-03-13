using Proxy;
using Proxy.Abstractions;

ICar realAudi = new RealCar("Audi");
realAudi.Drive();

ICar proxyCar = new CarProxy("Ford");
proxyCar.Drive();
proxyCar.Drive();