using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AbstractFactory_Singleton.AbstractFactory.Interfaces
{
    public interface ICar
    {
        IBodyType CreateBodyType();
        IPower CreatePower();
        IConsumption CreateConsumption();
        IPlace ShowPlace();
    }
}
