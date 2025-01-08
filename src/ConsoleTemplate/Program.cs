using ConsoleTemplate;
using ConsoleTemplate.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var hostBuilder = Host.CreateDefaultBuilder(args)
    .Configure();

var app = hostBuilder.Build();
await app.Services.GetRequiredService<MyApp>().StartAsync();