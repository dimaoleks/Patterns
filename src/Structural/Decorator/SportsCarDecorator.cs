using Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;
public class SportsCarDecorator(ICar _carDecorator) : CarDecorator(_carDecorator)
{
    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Added features for Sports Cars.");
    }
}
