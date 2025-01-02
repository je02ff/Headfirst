using System;
using System.Collections.Generic;

// 1. Weather Data Model
public class WeatherData
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
}

// 2. Weather Station (Observable)
public class WeatherStation : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers = new();
    private readonly WeatherData _weatherData = new();

    // Add an observer
    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        // Send the current weather data when a new observer subscribes
        observer.OnNext(_weatherData);
        return new Unsubscriber(_observers, observer);
    }

    // Method to simulate updating the weather data
    public void SetWeatherData(float temperature, float humidity, float pressure)
    {
        _weatherData.Temperature = temperature;
        _weatherData.Humidity = humidity;
        _weatherData.Pressure = pressure;
        
        NotifyObservers();
    }

    // Notify all observers of a change in weather data
    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(_weatherData);
        }
    }

    // Unsubscribe helper class
    private class Unsubscriber : IDisposable
    {
        private List<IObserver<WeatherData>> _observers;
        private IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}

// 3. Weather Display (Observer)
public class WeatherDisplay : IObserver<WeatherData>
{
    private string displayName;

    public WeatherDisplay(string name)
    {
        displayName = name;
    }

    // Called when the observable object (WeatherStation) sends new data
    public void OnNext(WeatherData value)
    {
        Console.WriteLine($"{displayName} Display - Current Weather:");
        Console.WriteLine($"Temperature: {value.Temperature}°C");
        Console.WriteLine($"Humidity: {value.Humidity}%");
        Console.WriteLine($"Pressure: {value.Pressure} hPa");
        Console.WriteLine();
    }

    // Called when the observable object (WeatherStation) encounters an error
    public void OnError(Exception error)
    {
        Console.WriteLine($"Error: {error.Message}");
    }

    // Called when the observable object (WeatherStation) completes the data stream (which is never in this case)
    public void OnCompleted()
    {
        Console.WriteLine($"{displayName} Display has completed.");
    }
}
