using ConsoleTemplate.Configuration;
using ConsoleTemplate.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConsoleTemplate;

public class MyApp(
    IService service,
    ILogger<MyApp> logger,
    IOptions<MySettings> options)
{
    public Task StartAsync()
    {
        logger.LogInformation("Starting service");
        
        service.Say(options.Value.Message);
        
        return Task.CompletedTask;
    }
}