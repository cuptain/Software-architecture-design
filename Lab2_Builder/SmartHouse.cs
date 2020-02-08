using System;
using System.Collections.Generic;
using System.Text;
using Lab2_Builder.Components;

namespace Lab2_Builder
{
    class SmartHouse
    {
        public List<Sensor> Sensors { get; set; }
        public List<Actuator> Actuators { get; set; }
        public List<OperatorPanel> OperatorPanels { get; set; }
        public List<MultimediaSystem> MultimediaSystems { get; set; }
        public List<ManagementController> ManagmentControllers { get; set; }
        public List<NetworkDevice> NetworkDevices { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Sensors != null)
                sb.Append("Сенсоры: \n");
            for (int i = 0; i < Sensors.Count; i++)
                if (Sensors[i].Count > 0)
                    sb.Append(Sensors[i].TypeOfSensor + " " + Sensors[i].TypeOfSignal + " кол-во:" + Sensors[i].Count + "\n");

            if (OperatorPanels != null)
                sb.Append("Панели оператора: \n");
            for (int i = 0; i < OperatorPanels.Count; i++)
                sb.Append(OperatorPanels[i].TypeOfOperatorPanel + "\n");

            if (Actuators != null)
                sb.Append("Исполнительные механизмы: \n");
            for (int i = 0; i < Actuators.Count; i++)
                sb.Append(Actuators[i].TypeOfActuator + "\n");

            if (MultimediaSystems != null)
                sb.Append("Мультимедиа системы: \n");
            for (int i = 0; i < MultimediaSystems.Count; i++)
                sb.Append(MultimediaSystems[i].TypeOfMS + "\n");

            if (ManagmentControllers != null)
                sb.Append("Контроллеры управления: \n");
            for (int i = 0; i < ManagmentControllers.Count; i++)
                sb.Append(ManagmentControllers[i].TypeOfController + "\n");

            if (NetworkDevices != null)
                sb.Append("Сетевые устройства: \n");
            for (int i = 0; i < NetworkDevices.Count; i++)
                sb.Append(NetworkDevices[i].TypeOfNetworkDevice + "\n");

            return sb.ToString();
        }
    }
}
