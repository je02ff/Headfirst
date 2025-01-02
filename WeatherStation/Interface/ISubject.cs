namespace WeatherStation.Interface;

public interface ISubject
{
    public void RegisterObserver(IObserver o);
    public void UnregisterObserver(IObserver o);
    public void NotifyObservers();
}