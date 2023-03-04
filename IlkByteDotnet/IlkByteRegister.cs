using System;
using IlkByteDotnet.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IlkByteDotnet;

public static class IlkByteRegister
{
    public static void RegisterIlkByte(this IServiceCollection services, IConfiguration configuration)
    {
        var config = new IlkByteAuth
        {
            Access = configuration["Ilkbyte:Access"].ToString(),
            Secret = configuration["Ilkbyte:Secret"].ToString(),
        };

        if (string.IsNullOrWhiteSpace(config.Access) || string.IsNullOrWhiteSpace(config.Secret))
        {
            throw new ArgumentNullException("Register faild! Please check the config!");
        }

        services.AddSingleton(config);
        services.AddScoped<IIlkByteService, IlkByteService>();
    }
}

