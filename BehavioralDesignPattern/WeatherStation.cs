using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBehavioralDesignPattern
{
    internal class WeatherStation : ISubject
    {
        private List<IObserver> observers = new();
        private float temperature;
        private float humidity;


        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetWeatherData(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            NotifyObservers();
        }
    }
}
