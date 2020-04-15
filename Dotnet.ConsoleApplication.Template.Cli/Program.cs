using System.Threading.Tasks;
using CommandLine;
using Dotnet.ConsoleApplication.Template.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.ConsoleApplication.Template.Cli
{
    public class Program
    {
        public static void Main(string[] args) =>
            Parser
                .Default
                .ParseArguments<Options>(args)
                .WithParsed(async options => await RunProgram(options));

        private static Task RunProgram(IOptions o)
        {
            var serviceProvider = DependencyResolver.Register();

            var entryPoint = serviceProvider.GetService<IEntryPoint>();

            return entryPoint.RunAsync(o);
        }
    }
}
