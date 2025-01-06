using ConsoleTemplate;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((builder, services) =>
    {
        services.Configure<MySettings>(builder.Configuration.GetSection("App"));
        services.AddTransient<IMyLogic, MyLogic>();
        services.AddSingleton<MyApp>();
    });

var app = hostBuilder.Build();
await app.Services.GetRequiredService<MyApp>().StartAsync();