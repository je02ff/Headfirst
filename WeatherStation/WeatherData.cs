using WeatherStation.Interface;

namespace WeatherStation;

public class WeatherData: ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private float _temperature;
    private float _humidity;
    private float _pressure;
    
    
    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void UnregisterObserver(IObserver o)
    {
        int index = _observers.IndexOf(o);
        if (index != -1)
        {
            _observers.RemoveAt(index);
        }
    }

    public void NotifyObservers()
    {
        foreach (IObserver o in _observers)
        {
            o.Update(_temperature, _humidity, _pressure);
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}