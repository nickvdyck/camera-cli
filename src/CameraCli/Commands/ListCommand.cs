using System;
using System.Linq;
using System.Threading.Tasks;
using CameraCli.Native;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.Commands
{
    public class ListCommand
    {
        private readonly IConsole _console;

        public ListCommand(IConsole console)
        {
            _console = console;
        }

        public async Task OnExecuteAsync()
        {
            var devices = DeviceManager.ListDevices().Where(d => d.Service == "usbvideo\0");

            var table = devices.ToStringTable(
                new[] { "NAME", "STATUS", "MANUFACTURER", "HANDLE" },
                d => d.Name,
                d =>
                {
                    var status = "unknown";

                    if (d.ConfigurationFlags == 0)
                    {
                        status = "enabled";
                    }
                    else if (d.ConfigurationFlags == DeviceConfigurationFlags.CONFIGFLAG_DISABLED)
                    {
                        status = "disabled";
                    }

                    return status;
                },
                d => d.Manufacturer,
                d => d.PhysicalDeviceObjectName
            );

            await _console.Out.WriteLineAsync("");
            await _console.Out.WriteLineAsync(table);
        }
    }
}
