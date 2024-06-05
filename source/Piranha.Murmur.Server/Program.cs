using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Piranha.Murmur.Server;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder.Services, builder.Configuration);
            var app = builder.Build();
            app.MapControllers();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine();
            Console.Error.WriteLine(ex);
            Console.Error.WriteLine();
        }
    }

    static void ConfigureServices(
        IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddControllers();
    }
}
