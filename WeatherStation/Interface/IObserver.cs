namespace WeatherStation.Interface;

public interface IObserver
{
    public void Update(float temperature, float humidity, float pressure);
}