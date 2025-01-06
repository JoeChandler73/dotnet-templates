using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConsoleTemplate;

public class MyApp(
    IMyLogic logic,
    ILogger<MyApp> logger,
    IOptions<MySettings> options)
{
    public Task StartAsync()
    {
        logic.Say(options.Value.Message);
        
        return Task.CompletedTask;
    }
}