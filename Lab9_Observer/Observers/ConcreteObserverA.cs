using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Coursera)
            {
                if ((subject as Coursera).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverA: Отреагировал на событие Coursera");
                }
            }
            else if (subject is DataCamp)
                if ((subject as DataCamp).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverA: Отреагировал на событие DataCamp");
                }
        }
    }
}
