using WeatherStation.Interface;

namespace WeatherStation;

public class HeatIndexDisplay: IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private float _pressure;
    private ISubject _weatherData;

    public HeatIndexDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    
    private float HeatIndex() => (_temperature*_humidity*_pressure);
    
    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"HeatIndexDisplay: {HeatIndex()}");
    }
}