using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers;

public class LoggerProvider : ILoggerProvider
{
    public LoggerProvider(string categoryName)
    {
        new HashLogger(categoryName);
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new HashLogger(categoryName);
    }
}