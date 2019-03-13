using System.Threading.Tasks;
using CameraCli.Devices;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.Commands
{
    public class UsedByCommand
    {
        private readonly IConsole _console;
        private readonly ICameraManager _deviceManager;

        public UsedByCommand(IConsole console, ICameraManager deviceManager)
        {
            _console = console;
            _deviceManager = deviceManager;
        }

        public async Task OnExecute()
        {
            var output = _deviceManager.UsedBy();

            await _console.Out.WriteAsync(output);
        }
    }
}
