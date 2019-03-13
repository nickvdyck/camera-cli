using System.Runtime.InteropServices;

namespace CameraCli.Native
{
    internal struct SP_CLASSINSTALL_HEADER
    {
        public uint cbSize;

        public ClassInstallerFunctionCode InstallFunction;
    }
}
