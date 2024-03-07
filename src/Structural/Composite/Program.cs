
using Composite.Equipments;

Engine engine = new("TFSI", 4500);

Body body1 = new("Left Door", 1200);
Body body2 = new("Right Door", 1200);

Tools tools = new("Bolt", 5);

Composite.Composite composite = new();

composite.AddEquipment(engine, body1, body2, tools);

composite.DisplayInfo();
