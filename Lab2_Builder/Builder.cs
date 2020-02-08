using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder
{
    abstract class Builder
    {
        public SmartHouse SmartHouse { get; private set; }
        public void CreateSmartHouse()
        {
            SmartHouse = new SmartHouse();
        }
        public abstract void SetSensors();
        public abstract void SetOperatorPanels();
        public abstract void SetActuators();
        public abstract void SetMultimediaSystems();
        public abstract void SetManagmentControllers();
        public abstract void SetNetworkDevices();
        public abstract SmartHouse GetSmartHouse();
    }
}
