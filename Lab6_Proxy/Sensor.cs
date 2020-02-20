using System;
using System.Collections.Generic;

namespace Lab6_Proxy
{
    public class Sensor: Component
    {
        public static List<string> TypesOfSensors = new List<string>() { "Влажность", "Температура", "Освещенность", "Шум", "Давление" };
        public static List<string> TypesOfSignals = new List<string>() { "Ниже нормы", "Норма", "Выше нормы" };

        public string TypeOfSensor { get; set; }
        public string TypeOfSignal { get; set; }

        public Sensor(int id, string name, DateTime date, string typeOfSensor, string typeOfSignal):base(id, name, date)
        {
            TypeOfSensor = typeOfSensor;
            TypeOfSignal = typeOfSignal;
        }
        public override void GetFunction()
        {
            Console.WriteLine("Тип устройства: " + name + " ID: " + id + " Функция: " + TypeOfSensor + " Сигнал:" + TypeOfSignal + " " + date);
        }
    }
}