using System;
using System.Collections.Generic;
using System.Text;


namespace Lab1_AbstractFactory_Singleton.Singleton
{
    class Garage
    {
        private static Garage _instance;
        private List<Car> cars = new List<Car>();

        private Garage(){ }

        public string ParkCar(Car car)
        {
            cars.Add(car);
            return ("Автомобиль " + car.Mark + car.Model + " успешно запаркован в гараж\n");
        }

        public static Garage getInstance()
        {
            if (_instance == null)
                _instance = new Garage();
            return _instance;
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
