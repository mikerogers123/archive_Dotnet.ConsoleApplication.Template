using System.Threading.Tasks;
using Dotnet.ConsoleApplication.Template.Contracts;

namespace Dotnet.ConsoleApplication.Template
{
    public class EntryPoint : IEntryPoint
    {
        private readonly ILogger _logger;

        public EntryPoint(ILogger logger)
        {
            _logger = logger;
        }

        public Task RunAsync(IOptions options)
        {
            _logger.Info("Hello world!");

            return Task.CompletedTask;
        }
    }
}
