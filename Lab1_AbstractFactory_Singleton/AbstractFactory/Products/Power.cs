using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Products
{
    public class Power : IPower
    {
        public void WriteAmountHP(double hp)
        {
            Console.WriteLine("Мощность двигателя: " + hp.ToString() + " л.с.");
        }
    }
}
