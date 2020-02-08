using System;
using System.Collections.Generic;
using System.Text;
using Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Products.Places
{
    public class PlaceToyota: IPlace
    {
        public void WritePlace()
        {
            Console.WriteLine("Город-производитель: Тоёта");
        }
    }
}
