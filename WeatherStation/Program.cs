// See https://aka.ms/new-console-template for more information

using WeatherStation.Interface;

namespace WeatherStation;

public class WeatherStation
{
    public static void Main(String[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
        
        weatherData.setMeasurements(80, 65, 30.4f);
        weatherData.setMeasurements(30, 65, 40.4f);
        weatherData.setMeasurements(20, 25, 20.4f);
    }
}