using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Builder.Components
{
    //Мультимедиа
    class MultimediaSystem
    {
        public static List<string> TypesOfMS = new List<string>() { "Домашний кинотеатр", 
            "Аудио система", 
            "Видео система",
            "Игровая система"};
        public string TypeOfMS { get; set; }
    }
}
