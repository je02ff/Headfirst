using WeatherStation.Interface;

namespace WeatherStation;

public class CurrentConditionDisplay: IDisplayElement, IObserver
{
    private float _temperature;
    private float _humidity;
    private ISubject _weatherData;
    
    public CurrentConditionDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        Display();
    }


    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity} humidity");
    }
}