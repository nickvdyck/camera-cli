using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using CameraCli.Devices;
using CameraCli.IO;
using CameraCli.Utils;
using McMaster.Extensions.CommandLineUtils;

namespace CameraCli.Commands
{
    public class EnableCommand
    {
        private readonly IConsole _console;
        private readonly ConsolePrompt _prompt;

        public EnableCommand(IConsole console, ConsolePrompt prompt)
        {
            _console = console;
            _prompt = prompt;
        }

        public async Task OnExecuteAsync()
        {
            if (!CurrentUser.IsAdmin())
            {
                await _console.Out.WriteLineAsync("Enabling your camera should be run as Administrator.");
                var elevate = await _prompt.GetYesNo("Would you like to run this command as admin");

                if (!elevate) return;

                using (var process = CurrentProcess.RunAsAdmin())
                using (var pipeServer = new NamedPipeServerStream("cameraclipipe", PipeDirection.In))
                {
                    process.Start();
                    pipeServer.WaitForConnection();

                    using (var sr = new StreamReader(pipeServer))
                    {
                        string line;
                        while ((line = await sr.ReadLineAsync()) != null && pipeServer.IsConnected)
                        {
                            await _console.Out.WriteLineAsync(line);
                        }
                    }

                    process.WaitForExit();
                }

                return;
            }

            var devices = DeviceManager.ListDevices();
            var device = devices.Where(d => d.Service == "usbvideo\0")
                .FirstOrDefault();

            await _console.Out.WriteLineAsync($"Enabling {device.Name}");

            DeviceManager.EnableDevice(device);

            devices = DeviceManager.ListDevices();
            device = devices.Where(d => d.Service == "usbvideo\0")
                .FirstOrDefault();

            var status = "unkown";

            if (device.ConfigurationFlags == 0)
            {
                status = "enabled";
            }
            else if (device.ConfigurationFlags == DeviceConfigurationFlags.CONFIGFLAG_DISABLED)
            {
                status = "disabled";
            }

            await _console.Out.WriteLineAsync($"{device.Name} | {device.InstanceId} | {status}");
        }
    }
}
