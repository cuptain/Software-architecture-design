using System;
using System.Collections.Generic;
using System.Text;
using Lab2_Builder.Components;

namespace Lab2_Builder.Builders
{
    class SH_ControlPanel : Builder
    {
        SmartHouse SmartHouse = new SmartHouse();
        static Random rnd = new Random();

        // Различные механизмы
        public override void SetActuators()
        {
            SmartHouse.Actuators = new List<Actuator>();
            for (int i = 0; i < Actuator.TypesOfActuators.Count; i++)
            {
                if (rnd.Next(0, 2) == 1)
                {
                    Actuator a = new Actuator();
                    a.TypeOfActuator = Actuator.TypesOfActuators[i];
                    SmartHouse.Actuators.Add(a);
                }
            }
        }

        // Различные контроллеры управления
        public override void SetManagmentControllers()
        {
            SmartHouse.ManagmentControllers = new List<ManagementController>();
            int count = rnd.Next(1, ManagementController.TypesOfControllers.Count + 1);
            if (count == 1)
            {
                ManagementController mc = new ManagementController();
                mc.TypeOfController = ManagementController.TypesOfControllers[rnd.Next(0, ManagementController.TypesOfControllers.Count)];
                SmartHouse.ManagmentControllers.Add(mc);
            }
            else
                for (int i = 0; i < count; i++)
                {
                    ManagementController mc = new ManagementController();
                    mc.TypeOfController = ManagementController.TypesOfControllers[i];
                    SmartHouse.ManagmentControllers.Add(mc);
                }
        }

        // Система мультимедиа
        public override void SetMultimediaSystems()
        {
            SmartHouse.MultimediaSystems = new List<MultimediaSystem>();
            MultimediaSystem ms = new MultimediaSystem();
            ms.TypeOfMS = MultimediaSystem.TypesOfMS[rnd.Next(0, MultimediaSystem.TypesOfMS.Count)];
            SmartHouse.MultimediaSystems.Add(ms);
        }

        // Различные сетевые устройства
        public override void SetNetworkDevices()
        {
            SmartHouse.NetworkDevices = new List<NetworkDevice>();
            for (int i = 0; i < NetworkDevice.TypesOfNetworkDevices.Count; i++)
            {
                if (rnd.Next(0, 2) == 1)
                {
                    NetworkDevice nd = new NetworkDevice();
                    nd.TypeOfNetworkDevice = NetworkDevice.TypesOfNetworkDevices[i];
                    SmartHouse.NetworkDevices.Add(nd);
                }
            }
        }

        // Панель оператора - Пульт
        public override void SetOperatorPanels()
        {
            SmartHouse.OperatorPanels = new List<OperatorPanel>();
            // Пульт
            OperatorPanel op = new OperatorPanel();
            op.TypeOfOperatorPanel = OperatorPanel.TypesOfOperatorPanes[1];
            SmartHouse.OperatorPanels.Add(op);
        }

        // Различные сенсоры
        public override void SetSensors()
        {
            SmartHouse.Sensors = new List<Sensor>();
            // Используются различные типы датчиков
            for (int i = 0; i < Sensor.TypesOfSensors.Count; i++)
            {
                Sensor s = new Sensor();
                s.Count = rnd.Next(0, 5);
                s.TypeOfSensor = Sensor.TypesOfSensors[i];
                s.TypeOfSignal = Sensor.TypesOfSignals[rnd.Next(0, Sensor.TypesOfSignals.Count)];
                SmartHouse.Sensors.Add(s);
            }
        }

        public override SmartHouse GetSmartHouse()
        {
            return SmartHouse;
        }
    }
}
