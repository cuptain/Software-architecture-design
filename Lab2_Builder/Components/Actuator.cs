using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Исполнитель
    class Actuator
    {
        public static List<string> TypesOfActuators = new List<string>() { "Электромеханические привода ворот", 
            "Электромеханические привода калиток",
            "Электромеханические привода дверей",
            "Электромеханические привода окон",
            "Электромеханические привода жалюзей и штор", 
            "Клапаны низкого, среднего и высокого давления"};
        public string TypeOfActuator { get; set; }
    }
}
