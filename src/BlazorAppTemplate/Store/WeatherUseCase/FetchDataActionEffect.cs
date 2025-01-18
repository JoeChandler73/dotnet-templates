using BlazorAppTemplate.Services;
using Fluxor;

namespace BlazorAppTemplate.Store.WeatherUseCase;

public class FetchDataActionEffect(IWeatherForecastService weatherForecastService) : Effect<FetchDataAction>
{
    public override async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
    {
        var forecasts = await weatherForecastService.GetForecastAsync();
        dispatcher.Dispatch(new FetchDataResultAction(forecasts));
    }
}