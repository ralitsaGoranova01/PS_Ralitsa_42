﻿using System.Collections.Concurrent;
using System.Text;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers;

public class HashLogger: ILogger
{
    private readonly ConcurrentDictionary<int, string> _logMessages;
    private readonly string _name;

    public HashLogger(string name)
    {
        _logMessages = new ConcurrentDictionary<int, string>();
        _name = name;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        var message = formatter(state, exception);
        switch (logLevel)
        {
            case LogLevel.Critical:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.WriteLine("--LOGGER--");
        var messageToBeLogged = new StringBuilder();
        messageToBeLogged.Append($"[{logLevel}]");
        messageToBeLogged.AppendFormat(" [{0}]", _name);
        Console.WriteLine(messageToBeLogged);
        Console.WriteLine($" {formatter(state, exception)}");
        Console.WriteLine("- LOGGER -");
        Console.ResetColor();
        _logMessages[eventId.Id] = message;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }
}