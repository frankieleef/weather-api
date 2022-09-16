using Microsoft.AspNetCore.Mvc;
using HelloWorld.App.Services;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.App.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Getting weather forecast.");
        List<WeatherForecast> weatherForecastList = new List<WeatherForecast>();
        WeatherService weatherService = new WeatherService();
        WeatherForecast weatherForecast = weatherService.GetForecast(DayOfWeek.Monday);

        weatherForecastList.Add(weatherForecast);
        return weatherForecastList;
    }
}

