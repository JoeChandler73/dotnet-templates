using BlazorAppTemplate.Services;
using Fluxor;

namespace BlazorAppTemplate.Configuration;

public static class ServiceConfiguration
{
    public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddSingleton<IWeatherForecastService, WeatherForecastService>()
            .AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly))
            .AddRazorComponents()
            .AddInteractiveServerComponents();
        
        return builder;
    }
}