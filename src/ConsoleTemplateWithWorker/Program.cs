using ConsoleWithWorker.Configuration;
using Microsoft.Extensions.Hosting;

var hostBuilder = Host.CreateDefaultBuilder(args)
    .Configure();
    
var host = hostBuilder.Build();

var tokenSource = new CancellationTokenSource();

Console.CancelKeyPress += (_, _) => tokenSource.Cancel();

await host.RunAsync(tokenSource.Token); 