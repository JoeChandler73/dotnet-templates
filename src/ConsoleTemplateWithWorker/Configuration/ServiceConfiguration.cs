using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleWithWorker.Configuration;

public static class ServiceConfiguration
{
    public static IHostBuilder Configure(this IHostBuilder hostBuilder)
    {
        hostBuilder
            .ConfigureServices((builder, services) =>
            {
                services.AddHostedService<Worker>();
            });

        return hostBuilder;
    }
}