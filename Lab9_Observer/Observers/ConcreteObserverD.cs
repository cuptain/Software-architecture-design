using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_Observer
{
    class ConcreteObserverD : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is DataCamp)
            {
                if ((subject as DataCamp).State == "Добавлен новый курс")
                {
                    Console.WriteLine("ConcreteObserverD: Отреагировал на событие DataCamp о добавлении курса");
                }
                if ((subject as DataCamp).State.Contains("Обновился курс"))
                {
                    Console.WriteLine("ConcreteObserverD: Отреагировал на событие DataCamp об обновлении курса");
                }
                if ((subject as DataCamp).State == "Обновились новости")
                {
                    Console.WriteLine("ConcreteObserverD: Отреагировал на событие DataCamp об обновлении новостей");
                }
            }
        }
    }
}
