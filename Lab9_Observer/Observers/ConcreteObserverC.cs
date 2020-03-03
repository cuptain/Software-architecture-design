using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    class ConcreteObserverC : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Coursera)
            {
                if ((subject as Coursera).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverC: Отреагировал на событие Coursera о добавлении курса");
                }
                if ((subject as Coursera).State.Contains("Обновился курс"))
                {
                    Console.WriteLine("ConcreteObserverC: Отреагировал на событие Coursera об обновлении курса");
                }
                if ((subject as Coursera).State == "Обновились новости")
                {
                    Console.WriteLine("ConcreteObserverC: Отреагировал на событие Coursera об обновлении новостей");
                }
            }
        }
    }
}
