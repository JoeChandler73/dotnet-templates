using Microsoft.Extensions.Options;
using WebApiTemplate.Configuration;

namespace WebApiTemplate.Services;

public class Service(IOptions<MySettings> options) : IService
{
    public string GetMessage()
    {
        return options.Value.Message;
    }
}