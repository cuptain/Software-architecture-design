using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products.Places;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Products.BodyTypes;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Factories
{
    public class PlantMunich : ICar
    {
        public IPlace ShowPlace()
        {
            return new PlaceMunich();
        }

        public IBodyType CreateBodyType()
        {
            return new BodyTypeHatchback();
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
