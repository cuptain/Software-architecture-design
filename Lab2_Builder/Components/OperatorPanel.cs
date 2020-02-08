using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Панель оператора
    class OperatorPanel
    {
        public static List<string> TypesOfOperatorPanes = new List<string>() { "Пульт", 
            "Панель управления", 
            "Мобильные устройства" };
        public string TypeOfOperatorPanel { get; set; }
    }
}
