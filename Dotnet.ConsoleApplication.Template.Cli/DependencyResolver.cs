using System;
using Dotnet.ConsoleApplication.Template.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.ConsoleApplication.Template.Cli
{
    public static class DependencyResolver
    {
        public static IServiceProvider Register() =>
            new ServiceCollection()
                .AddScoped<IEntryPoint, EntryPoint>()
                .AddScoped<ILog, Log>()
                .AddScoped<IInputReader, InputReader>()
                .BuildServiceProvider();
    }
}