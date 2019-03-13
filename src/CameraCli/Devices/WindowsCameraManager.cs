using System.Linq;
using CameraCli.Native;

namespace CameraCli.Devices
{
    public class WindowsCameraManager : ICameraManager
    {
        public string UsedBy()
        {
            throw new System.NotImplementedException();
        }

        public void Enable()
        {
            var devices = DeviceManager.ListDevices();
            var device = devices.Where(d => d.Service == "usbvideo\0")
                .FirstOrDefault();

            // Device is already enabled
            if (device.ConfigurationFlags == 0) return;


            DeviceManager.EnableDevice(device);
        }

        public void Disable()
        {
            var devices = DeviceManager.ListDevices();
            var device = devices.Where(d => d.Service == "usbvideo\0")
                .FirstOrDefault();

            // Device is already disabled
            if (device.ConfigurationFlags == DeviceConfigurationFlags.CONFIGFLAG_DISABLED) return;

            DeviceManager.DisableDevice(device);
        }
    }
}

// var devices = DeviceManager.ListDevices();
// var device = devices.Where(d => d.Service == "usbvideo\0")
//     .FirstOrDefault();

// await _console.Out.WriteLineAsync($"Enabling {device.Name}");

// DeviceManager.EnableDevice(device);

// devices = DeviceManager.ListDevices();
// device = devices.Where(d => d.Service == "usbvideo\0")
//     .FirstOrDefault();

// var status = "unkown";

// if (device.ConfigurationFlags == 0)
// {
//     status = "enabled";
// }
// else if (device.ConfigurationFlags == DeviceConfigurationFlags.CONFIGFLAG_DISABLED)
// {
//     status = "disabled";
// }

// await _console.Out.WriteLineAsync($"{device.Name} | {device.InstanceId} | {status}");

