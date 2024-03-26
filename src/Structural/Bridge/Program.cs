using Bridge.Abstractions;
using Bridge.Factories;

Owner owner = new(new GermanFactory());

ICar car = owner.Do();

car.Go();

owner.ChangeFactory(new JapaneseFactory());

car = owner.Do();

car.Go();

