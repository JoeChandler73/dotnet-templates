using Microsoft.Extensions.Logging;

namespace ConsoleTemplate;

public class MyLogic(ILogger<MyLogic> logger) : IMyLogic
{
    public void Say(string message)
    {
        logger.LogInformation(message);
    }
}