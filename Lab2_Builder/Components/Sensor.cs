using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Датчик
    class Sensor
    {
        public static List<string> TypesOfSensors = new List<string>() { "Влажность", "Температура", "Освещенность" };
        public static List<string> TypesOfSignals = new List<string>() { "Ниже нормы", "Норма", "Выше нормы" };

        public string TypeOfSensor { get; set; }
        public string TypeOfSignal { get; set; }
        public int Count { get; set; }
    }
}
