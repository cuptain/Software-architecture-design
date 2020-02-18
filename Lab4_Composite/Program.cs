using System;

namespace Lab4_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component Car = new Composite("Car");
            Component Engine = new Composite("Engine");
            Car.Add(Engine);
            Component cylinderBlock = new Leaf("Cylinder block");
            Engine.Add(cylinderBlock);
            Component cylinderPistonGroup = new Leaf("Cylinder piston group");
            Engine.Add(cylinderPistonGroup);
            Component Cooler = new Leaf("Cooler");
            Engine.Add(Cooler);
            Component carElectronic = new Composite("Electric");
            Car.Add(carElectronic);
            Component Generator = new Leaf("Generator");
            carElectronic.Add(Generator);
            Component Battery = new Leaf("Battery");
            carElectronic.Add(Battery);
            Component Suspension = new Composite("Suspension");
            Car.Add(Suspension);
            Component Springs = new Leaf("Springs");
            Suspension.Add(Springs);
            Component Bearings = new Leaf("Bearings");
            Suspension.Add(Bearings);
            Car.Display(1);
        }
    }
}
