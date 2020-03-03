using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab9_Observer
{
    class Coursera : ISubject
    {

        public string State { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Coursera: Новая подписка.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Coursera: Кто-то отписался.");
        }

        public void Notify()
        {
            Console.WriteLine("Coursera: Оповещение подписчиков...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void AddNewCourse()
        {
            Console.WriteLine("\nCoursera: Добавлен новый курс.");
            this.State = "Добавлен новый курс";

            Thread.Sleep(15);

            Console.WriteLine("Coursera: Обновилось состояние: " + this.State);
            this.Notify();
        }

        public void AddNews()
        {
            Console.WriteLine("\nCoursera: Появились свежие новости.");
            this.State = "Обновились новости";

            Thread.Sleep(15);

            Console.WriteLine("Coursera: Обновилось состояние: " + this.State);
            this.Notify();
        }

        public void UpdateCourse(string name)
        {
            Console.WriteLine("\nCourera: Обновился курс \"" + name + "\"");
            this.State = "Обновился курс \"" + name + "\"";

            Thread.Sleep(15);

            Console.WriteLine("Coursera: Обновилось состояние: " + this.State);
            this.Notify();
        }
    }
}
