using System;
using System.Linq;
using System.Threading.Tasks;
using CameraCli.Devices;
using CameraCli.Native;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.Commands
{
    public class ListCommand
    {
        private readonly IConsole _console;
        private readonly ICameraManager _cameraManger;

        public ListCommand(IConsole console, ICameraManager cameraManger)
        {
            _console = console;
            _cameraManger = cameraManger;
        }

        public async Task OnExecuteAsync()
        {
            var cameras = _cameraManger.List();

            var table = cameras.ToStringTable(
                new[] { "NAME", "ENABLED", },
                d => d.Name,
                d => d.Enabled ? "yes" : "no"
            );

            await _console.Out.WriteLineAsync(table);
        }
    }
}
