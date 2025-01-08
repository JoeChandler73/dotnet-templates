using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsoleWithWorker;

public class Worker(ILogger<Worker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        
        int loop = 0;
        while (!stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation($"Worker called {++loop} times. {DateTime.Now.ToString("T")}");

            await Task.Delay(1000, stoppingToken);
        }
    }

    public override Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation($"Worker stopped.");
        
        return base.StopAsync(cancellationToken);
    }
}