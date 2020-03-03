using System;

namespace Lab9_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var coursera = new Coursera();
            var datacamp = new DataCamp();
            var observerA = new ConcreteObserverA();
            coursera.Attach(observerA);
            datacamp.Attach(observerA);

            var observerB = new ConcreteObserverB();
            coursera.Attach(observerB);
            datacamp.Attach(observerB);

            var observerC = new ConcreteObserverC();
            coursera.Attach(observerC);
            datacamp.Attach(observerC);

            var observerD = new ConcreteObserverD();
            coursera.Attach(observerD);
            datacamp.Attach(observerD);

            coursera.AddNewCourse();
            coursera.AddNews();
            coursera.UpdateCourse("Компьютерная графика");

            datacamp.AddNewCourse();
            datacamp.AddNews();
            datacamp.UpdateCourse("Машинное обучение");
        }
    }
}
