using System.Runtime.InteropServices;

namespace CameraCli.Native
{
    internal struct SP_PROPCHANGE_PARAMS
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        public DeviceStateChange StateChange;

        public DeviceStateChangeScope Scope;

        public uint HwProfile;
    }
}
