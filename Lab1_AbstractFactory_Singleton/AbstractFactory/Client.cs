using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory
{
    class Client
    {
        private IPlace place;
        private IBodyType body;
        private IPower power;
        private IConsumption consumption;
        public Client(ICar factory)
        {
            place = factory.ShowPlace();
            body = factory.CreateBodyType();
            power = factory.CreatePower();
            consumption = factory.CreateConsumption();
        }

        public void WritBodyType()
        {
            body.WriteBodyType();
        }

        public void WriteAmountHP(double hp)
        {
            power.WriteAmountHP(hp);
        }

        public void WriteNumberFuelConsumprion(double fuelConsumption)
        {
            consumption.WriteNumberFuelConsumprion(fuelConsumption);
        }
        public void WritePlace()
        {
            place.WritePlace();
        }
    }
}
