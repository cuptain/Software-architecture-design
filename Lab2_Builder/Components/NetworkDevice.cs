using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Сетевые устройства
    class NetworkDevice
    {
        public static List<string> TypesOfNetworkDevices = new List<string>() { "ПК",
            "Ноутбук",
            "Планшет",
            "Смартфон" };
        public string TypeOfNetworkDevice { get; set; }
    }
}
