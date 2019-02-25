using System.Runtime.InteropServices;

namespace CameraCli.Devices
{
    internal struct SP_CLASSINSTALL_HEADER
    {
        public uint cbSize;

        public ClassInstallerFunctionCode InstallFunction;
    }
}