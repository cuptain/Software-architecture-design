using System.Collections.Generic;
using System;

namespace Lab6_Proxy
{
    public class ComponentContext
    {
        public List<Component> Components { get; set; }
        public ComponentContext()
        {
            Components = new List<Component>();
            int id = 1;
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[0], Sensor.TypesOfSignals[0]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[1], Sensor.TypesOfSignals[1]));
            Components.Add(new Actuator(id++, "Исполнительный механизм", DateTime.Now, Actuator.TypesOfActuators[0], Actuator.StatusesOfActuators[0]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[2], Sensor.TypesOfSignals[2]));
            Components.Add(new Actuator(id++, "Исполнительный механизм", DateTime.Now, Actuator.TypesOfActuators[1], Actuator.StatusesOfActuators[0]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[3], Sensor.TypesOfSignals[0]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[4], Sensor.TypesOfSignals[1]));
            Components.Add(new Actuator(id++, "Исполнительный механизм", DateTime.Now, Actuator.TypesOfActuators[2], Actuator.StatusesOfActuators[1]));
            Components.Add(new Actuator(id++, "Исполнительный механизм", DateTime.Now, Actuator.TypesOfActuators[3], Actuator.StatusesOfActuators[0]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[3], Sensor.TypesOfSignals[2]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[2], Sensor.TypesOfSignals[0]));
            Components.Add(new Actuator(id++, "Исполнительный механизм", DateTime.Now, Actuator.TypesOfActuators[4], Actuator.StatusesOfActuators[1]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[1], Sensor.TypesOfSignals[1]));
            Components.Add(new Sensor(id++, "Сенсор", DateTime.Now, Sensor.TypesOfSensors[0], Sensor.TypesOfSignals[2]));
        }
    }
}