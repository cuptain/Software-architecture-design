using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Products.BodyTypes
{
    public class BodyTypeSedan : IBodyType
    {
        public void WriteBodyType()
        {
            Console.WriteLine("Тип кузова: Седан");
        }
    }
}
