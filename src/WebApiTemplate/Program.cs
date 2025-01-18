using WebApiTemplate;
using WebApiTemplate.Configuration;
using WebApiTemplate.Services;

var builder = WebApplication.CreateBuilder(args)
    .Configure();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/message", (IService service) =>
    {
        return service.GetMessage();
    })
    .WithName("GetMessage");

app.Run();