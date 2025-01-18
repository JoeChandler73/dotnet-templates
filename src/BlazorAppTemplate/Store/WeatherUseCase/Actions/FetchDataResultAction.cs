using BlazorAppTemplate.Models;

namespace BlazorAppTemplate.Store.WeatherUseCase.Actions;

public class FetchDataResultAction(IEnumerable<WeatherForecast> forecasts)
{
    public IEnumerable<WeatherForecast> Forecasts { get; } = forecasts;
}