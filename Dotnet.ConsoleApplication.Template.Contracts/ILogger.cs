namespace Dotnet.ConsoleApplication.Template.Contracts
{
    public interface ILogger
    {
        void Success(string message);
        void Error(string message);
        void Info(string message);
    }
}