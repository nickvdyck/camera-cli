using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using CameraCli.IO;
using CameraCli.Utils;
using CameraCli.Devices;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.Commands
{
    public class EnableCommand
    {
        private readonly IConsole _console;
        private readonly ICameraManager _deviceManger;

        public EnableCommand(IConsole console, ICameraManager deviceManger)
        {
            _console = console;
            _deviceManger = deviceManger;
        }

        public async Task<int> OnExecuteAsync()
        {
            if (!CurrentUser.IsAdminOrRoot())
            {
                await _console.Out.WriteLineAsync("Enabling your camera should be run as Administrator.");
                return 1;
            }

            _deviceManger.Enable();

            return 0;
        }
    }
}
