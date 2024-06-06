using Microsoft.Extensions.Configuration;
using System;
namespace DehasoftOne.Data.Concrete;
public class ConfigurationHelper
{
    private readonly IConfiguration _configuration;

    public ConfigurationHelper()
    {
        _configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }

    public string GetConnectionString(string name)
    {
        return _configuration.GetConnectionString(name);
    }
}
