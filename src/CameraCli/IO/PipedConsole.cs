using System;
using System.IO;
using System.IO.Pipes;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.IO
{
    public class PipedConsole : IConsole, IDisposable
    {
        private readonly NamedPipeClientStream _pipeOut;
        private readonly TextWriter _out;

        public PipedConsole(string namedPipeOut)
        {
            _pipeOut = new NamedPipeClientStream(".", namedPipeOut, PipeDirection.Out);
            var writer = new StreamWriter(_pipeOut);

            _pipeOut.Connect();
            writer.AutoFlush = true;

            _out = TextWriter.Synchronized(writer);
        }

        public TextWriter Out => _out;

        public TextWriter Error => throw new NotImplementedException();

        public TextReader In => throw new NotImplementedException();

        public bool IsInputRedirected => true;

        public bool IsOutputRedirected => true;

        public bool IsErrorRedirected => true;

        public ConsoleColor ForegroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ConsoleColor BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event ConsoleCancelEventHandler CancelKeyPress;

        public void ResetColor()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _out.Dispose();
            _pipeOut.Dispose();
        }
    }
}
