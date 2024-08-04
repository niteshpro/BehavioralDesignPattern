using ObserverBehavioralDesignPattern;
class Program
{
    static void Main()
    {
        WeatherStation weatherStation = new WeatherStation();

        TemperatureDisplay tempDisplay = new TemperatureDisplay();
        HumidityDisplay humidityDisplay = new HumidityDisplay();

        weatherStation.RegisterObserver(tempDisplay);
        weatherStation.RegisterObserver(humidityDisplay);

        weatherStation.SetWeatherData(25.3f, 65.4f);
        weatherStation.SetWeatherData(22.1f, 70.2f);
    }
}
