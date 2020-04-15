using CommandLine;
using Dotnet.ConsoleApplication.Template.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.ConsoleApplication.Template.Cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(async o => await ServiceProviderFactory
                    .Create()
                    .GetService<IEntryPoint>()
                    .RunAsync(o));
        }
    }
}
