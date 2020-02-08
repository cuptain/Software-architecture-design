using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products.Places;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products.BodyTypes;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Factories
{
    public class PlantToyota : ICar
    {
        public IPlace ShowPlace()
        {
            return new PlaceToyota();
        }

        public IBodyType CreateBodyType()
        {
            return new BodyTypeSedan();
        }

        public IPower CreatePower()
        {
            return new Power();
        }

        public IConsumption CreateConsumption()
        {
            return new Consumption();
        }
    }
}
