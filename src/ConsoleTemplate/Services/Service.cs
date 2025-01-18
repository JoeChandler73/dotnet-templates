using Microsoft.Extensions.Logging;

namespace ConsoleTemplate.Services;

public class Service(ILogger<Service> logger) : IService
{
    public void Say(string message)
    {
        logger.LogInformation(message);
    }
}