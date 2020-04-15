using System;
using Dotnet.ConsoleApplication.Template.Contracts;

namespace Dotnet.ConsoleApplication.Template.Cli
{
    public class InputReader : IInputReader
    {
        public string Read() => Console.ReadLine();
    }
}