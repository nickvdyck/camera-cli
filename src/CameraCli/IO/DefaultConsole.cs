using System;
using System.IO;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.IO
{
    public class DefaultConsole : IConsole
    {

        public event ConsoleCancelEventHandler CancelKeyPress
        {
            add => Console.CancelKeyPress += value;
            remove => Console.CancelKeyPress -= value;
        }

        public TextWriter Error => Console.Error;

        public TextReader In => Console.In;

        public TextWriter Out => Console.Out;

        public bool IsInputRedirected => Console.IsInputRedirected;

        public bool IsOutputRedirected => Console.IsOutputRedirected;

        public bool IsErrorRedirected => Console.IsErrorRedirected;

        public ConsoleColor ForegroundColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }

        public ConsoleColor BackgroundColor
        {
            get => Console.BackgroundColor;
            set => Console.BackgroundColor = value;
        }

        public void ResetColor() => Console.ResetColor();
    }
}
