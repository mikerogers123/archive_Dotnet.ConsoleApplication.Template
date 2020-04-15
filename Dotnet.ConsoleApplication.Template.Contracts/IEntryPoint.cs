using System.Threading.Tasks;

namespace Dotnet.ConsoleApplication.Template.Contracts
{
    public interface IEntryPoint
    {
        Task RunAsync(IOptions options);
    }
}