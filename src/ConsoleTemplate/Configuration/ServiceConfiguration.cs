using ConsoleTemplate.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleTemplate.Configuration;

public static class ServiceConfiguration
{
    public static IHostBuilder Configure(this IHostBuilder hostBuilder)
    {
        hostBuilder
            .ConfigureServices((builder, services) =>
            {
                services.Configure<MySettings>(builder.Configuration.GetSection("App"));
                services.AddSingleton<IService, Service>();
                services.AddSingleton<MyApp>();
            });

        return hostBuilder;
    }
}