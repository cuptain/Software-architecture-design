using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Products
{
    public class Consumption : IConsumption
    {
        public void WriteNumberFuelConsumprion(double fuelConsumption)
        {
            Console.WriteLine("Расход топлива (смешанный цикл): " + fuelConsumption.ToString() + " л/100 км\n");
        }
    }
}
