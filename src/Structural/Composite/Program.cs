using Composite;
using Composite.Equipments;

Car audi = new("Audi");

audi.AddEquipment(new Engine("TFSI", 4500));
audi.AddEquipment(new Body("Left Door", 1200));
audi.AddEquipment(new Tools("Bolt", 5));

audi.DisplayInfo();
