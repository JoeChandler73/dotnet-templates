using WebApiTemplate.Services;

namespace WebApiTemplate.Configuration;

public static class ServiceConfiguration
{
    public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
    {
        builder.Services
            .Configure<MySettings>(builder.Configuration.GetSection("App"))
            .AddSingleton<IService, Service>()
            .AddOpenApi()
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();
        
        return builder;
    }
}