using BlazorAppTemplate.Models;

namespace BlazorAppTemplate.Services;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync();
}