using HelloWorld.App.Services;
using System;

namespace HelloWorld.Tsts;

public class UnitTest1
{
    [Fact]
    public void TestIfCorrectDayOfWeek()
    {
        var weatherService = new WeatherService();
        var weatherForecast = weatherService.GetForecast(DayOfWeek.Monday);
        Assert.Equal(1, (int)weatherForecast.Date.Day);
    }
}