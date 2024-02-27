using Prototype;
using Prototype.Abstractions;
using System.Drawing;

IFruit apple = new Apple(new(120, Color.Red));
IFruit appleShallowClone = apple.ShallowClone();

Console.WriteLine($"APPLE: Is references equal with shallow clone? = {apple.Equals(appleShallowClone)}");
Console.WriteLine($"APPLE: Is references internal properties equal with shallow clone? = {apple.Characteristic.Equals(appleShallowClone.Characteristic)}");

IFruit appleDeepClone = apple.DeepClone();

Console.WriteLine($"APPLE: Is references equal with deep clone? = {apple.Equals(appleDeepClone)}");
Console.WriteLine($"APPLE: Is references internal properties equal with deep clone? = {apple.Characteristic.Equals(appleDeepClone.Characteristic)}");

Console.WriteLine();
Console.WriteLine("########################################");
Console.WriteLine();

IFruit orange = new Orange(new(130, Color.Orange));
IFruit orangeShallowClone = orange.ShallowClone();

Console.WriteLine($"ORANGE: Is references equal with shallow clone? = {orange.Equals(orangeShallowClone)}");
Console.WriteLine($"Orange: Is references internal properties equal with shallow clone? = {orange.Characteristic.Equals(orangeShallowClone.Characteristic)}");

IFruit orangeDeepClone = orange.DeepClone();

Console.WriteLine($"ORANGE: Is references equal with deep clone? = {orange.Equals(orangeDeepClone)}");
Console.WriteLine($"ORANGE: Is references internal properties equal with deep clone? = {orange.Characteristic.Equals(orangeDeepClone.Characteristic)}");


Console.WriteLine();