using System;

namespace HelloWorld.App.Services;

public class WeatherService {
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecast GetForecast(DayOfWeek dayOfWeek) 
    {
        DateTime currentDate = new DateTime();
        return new WeatherForecast()
        {
            Date = new DateTime(currentDate.Year, currentDate.Month, (int)dayOfWeek),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
}