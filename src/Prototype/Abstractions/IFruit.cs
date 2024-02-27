using System.Reflection.PortableExecutable;

namespace Prototype.Abstractions;

public interface IFruit
{
    Characteristic Characteristic { get;  }

    IFruit ShallowClone();
    IFruit DeepClone();
}
