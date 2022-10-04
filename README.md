# Archived
Replaced with https://github.com/mikerogers123/Dotnet.Cli.CookieCutter

# Dotnet.ConsoleApplication.Template
Template code for a .NET Core C# console application with the following key attributes:

## Dependency Injection
Configured in CLI project before calling into the main entry point to the app.

## Logging
Implemented in the CLI project but defined in the Contracts project.

## Asynchronous entry point
Called from the CLI project but defined in a purpose-built project.

## Typed command line arguments
Implemented in the CLI project but defined in the Contracts project.

# Usage Guidelines
- Clone repo
- Rename the projects, replacing *Dotnet.ConsoleApplication.Template* with *YOUR_SOLUTION_NAME*
- To run, run as you would any other .NET console app - either using the famous play button in Visual Studio with the CLI project set as startup project, or by using the dotnet CLI from a terminal
