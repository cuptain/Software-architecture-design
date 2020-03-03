using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab9_Observer
{
    class DataCamp : ISubject
    {

        public string State { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("DataCamp: Новая подписка.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("DataCamp: Кто-то отписался.");
        }

        public void Notify()
        {
            Console.WriteLine("DataCamp: Оповещение подписчиков...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void AddNewCourse()
        {
            Console.WriteLine("\nDataCamp: Добавлен новый курс.");
            this.State = "Добавлен новый курс";

            Thread.Sleep(15);

            Console.WriteLine("DataCamp: Обновилось состояние: " + this.State);
            this.Notify();
        }

        public void AddNews()
        {
            Console.WriteLine("\nDataCamp: Появились свежие новости.");
            this.State = "Обновились новости";

            Thread.Sleep(15);

            Console.WriteLine("DataCamp: Обновилось состояние: " + this.State);
            this.Notify();
        }

        public void UpdateCourse(string name)
        {
            Console.WriteLine("\nDataCamp: Обновился курс \"" + name + "\"");
            this.State = "Обновился курс \"" + name + "\"";

            Thread.Sleep(15);

            Console.WriteLine("DataCamp: Обновилось состояние: " + this.State);
            this.Notify();
        }
    }
}
