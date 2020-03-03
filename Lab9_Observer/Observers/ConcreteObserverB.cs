using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Coursera)
            {
                if ((subject as Coursera).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие Coursera о добавлении курса");
                }
                if ((subject as Coursera).State.Contains("Обновился курс"))
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие Coursera об обновлении курса");
                }
                if ((subject as Coursera).State == "Обновились новости")
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие Coursera об обновлении новостей");
                }
            }
            else if (subject is DataCamp)
            {
                if ((subject as DataCamp).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие DataCamp о добавлении курса");
                }
                if ((subject as DataCamp).State.Contains("Обновился курс"))
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие DataCamp об обновлении курса");
                }
                if ((subject as DataCamp).State == "Обновились новости")
                {
                    Console.WriteLine("ConcreteObserverB: Отреагировал на событие DataCamp об обновлении новостей");
                }
            }
        }
    }
}
