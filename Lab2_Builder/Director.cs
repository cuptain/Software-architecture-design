using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Builders
{
    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.CreateSmartHouse();
            builder.SetSensors();
            builder.SetOperatorPanels();
            builder.SetActuators();
            builder.SetMultimediaSystems();
            builder.SetManagmentControllers();
            builder.SetNetworkDevices();
        }
    }
}
