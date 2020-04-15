using System;
using Dotnet.ConsoleApplication.Template.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.ConsoleApplication.Template.Cli
{
    public static class ServiceProviderFactory
    {
        public static IServiceProvider Create()
        {
            return new ServiceCollection()
                .AddScoped<IEntryPoint, EntryPoint>()
                .AddScoped<ILogger, Logger>()
                .AddScoped<IInputReader, InputReader>()
                .BuildServiceProvider();
        }
    }
}