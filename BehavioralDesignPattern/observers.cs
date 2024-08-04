using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBehavioralDesignPattern
{
    public class TemperatureDisplay : IObserver
    {
        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"Temperature Display: Temperature is {temperature}°C");
        }
    }

    public class HumidityDisplay : IObserver
    {
        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"Humidity Display: Humidity is {humidity}%");
        }
    }

}
