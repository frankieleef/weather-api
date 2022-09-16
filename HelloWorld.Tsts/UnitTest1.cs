using HelloWorld.App;
using HelloWorld.App.Services;
using System;
using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace HelloWorld.Tsts;

public class UnitTest1
{
    [Fact]
    public void TestIfCorrectDayOfWeek()
    {
        var weatherService = new WeatherService();
        var weatherForecast = weatherService.GetForecast(DayOfWeek.Monday);
        Assert.Equal(2, (int)weatherForecast.Date.Day);
    }

    [Fact]
    public async void GET_retrieve_weather_forecast()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetAsync("/weatherforecast");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}