using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using CameraCli.Native;
using CameraCli.IO;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;
using CameraCli.Devices;

namespace CameraCli.Commands
{
    public class DisableCommand
    {
        private readonly IConsole _console;
        private readonly ICameraManager _deviceManager;

        public DisableCommand(IConsole console, ICameraManager deviceManager)
        {
            _console = console;
            _deviceManager = deviceManager;
        }

        public async Task<int> OnExecuteAsync()
        {
            if (!CurrentUser.IsAdminOrRoot())
            {
                await _console.Out.WriteLineAsync("Enabling your camera should be run as Administrator.");
                return 1;
            }

            _deviceManager.Disable();

            return 0;
        }
    }
}
