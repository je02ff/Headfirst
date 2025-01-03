// Create the weather station
WeatherStation weatherStation = new WeatherStation();

// Create two displays (observers) that will listen for updates
WeatherDisplay display1 = new WeatherDisplay("Main");
WeatherDisplay display2 = new WeatherDisplay("Secondary");

// Subscribe the displays to the weather station
IDisposable subscription1 = weatherStation.Subscribe(display1);
IDisposable subscription2 = weatherStation.Subscribe(display2);

// Simulate updating the weather data
Console.WriteLine("Setting weather data...");
weatherStation.SetWeatherData(25.3f, 60.5f, 1013.1f);
weatherStation.SetWeatherData(26.7f, 58.2f, 1012.8f);
weatherStation.SetWeatherData(24.5f, 65.0f, 1013.5f);

// Unsubscribe one of the displays (e.g., secondary display)
Console.WriteLine("\nUnsubscribing secondary display...");
subscription2.Dispose();

// Simulate further weather data updates
weatherStation.SetWeatherData(22.1f, 70.5f, 1012.0f);
weatherStation.SetWeatherData(20.3f, 75.2f, 1011.5f);