using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Контроллер управления
    class ManagementController
    {
        public static List<string> TypesOfControllers = new List<string>() { "Общий", "Местный" };
        public string TypeOfController { get; set; }
    }
}
