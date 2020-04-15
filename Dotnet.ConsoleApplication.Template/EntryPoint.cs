using System.Threading.Tasks;
using Dotnet.ConsoleApplication.Template.Contracts;

namespace Dotnet.ConsoleApplication.Template
{
    public class EntryPoint : IEntryPoint
    {
        private readonly ILog _log;

        public EntryPoint(ILog log) => _log = log;

        public Task RunAsync(IOptions options)
        {
            _log.Info("Hello world!");

            return Task.CompletedTask;
        }
    }
}
