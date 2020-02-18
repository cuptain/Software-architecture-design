using System;
using System.Collections.Generic;

namespace Lab6_Proxy
{
    class Actuator: Component
    {
        public static List<string> TypesOfActuators = new List<string>() { "Привода открытия/закрытия ворот", "Привода открытия/закрытия калиток",
    "Привода открытия/закрытия дверей", "Привода открытия/закрытия окон", "Привода открытия/закрытия жалюзей и штор"};
        public static List<string> StatusesOfActuators = new List<string>() { "Открыто", "Закрыто" };

        public string TypeOfActuator { get; set; }
        public string StatusOfActuator { get; set; }

        public Actuator(int id, string name, DateTime date, string typeOfActuator, string statusOfActuator):base(id, name, date)
        {
            TypeOfActuator = typeOfActuator;
            StatusOfActuator = statusOfActuator;
        }
        public override void GetFunction()
        {
            Console.WriteLine("Тип устройства: " + name + " ID: " + id + " Функция: " + TypeOfActuator + " Статус: " + StatusOfActuator + " " + date);
        }
    }

}