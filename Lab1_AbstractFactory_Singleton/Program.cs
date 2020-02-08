using System;
using Lab1_AbstractFactory_Singleton.AbstractFactory;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Factories;
using Lab1_AbstractFactory_Singleton.Singleton;

namespace Lab1_AbstractFactory_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory:\n");
            Client client1 = new Client(new PlantDetroit());
            client1.WritePlace();
            client1.WritBodyType();
            client1.WriteAmountHP(660);
            client1.WriteNumberFuelConsumprion(22);

            Client client2 = new Client(new PlantToyota());
            client2.WritePlace();
            client2.WritBodyType();
            client2.WriteAmountHP(105);
            client2.WriteNumberFuelConsumprion(16);

            Client client3 = new Client(new PlantMunich());
            client3.WritePlace();
            client3.WritBodyType();
            client3.WriteAmountHP(89);
            client3.WriteNumberFuelConsumprion(8.5);

            Console.WriteLine("Singleton:\n");

            Garage garage = Garage.getInstance();
            Console.WriteLine(garage.ParkCar(new Car() { Mark = "Nissan", Model = "Bluebird" }));
            Console.WriteLine(garage.ParkCar(new Car() { Mark = "LADA", Model = "2107" }));
            Console.WriteLine("Список запаркованных машин:\n");
            foreach (var c in garage.GetCars())
            {
                Console.WriteLine(c.Mark + " " + c.Model + "\n");
            }
        }
    }
}
