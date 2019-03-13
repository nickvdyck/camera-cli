using System;

namespace CameraCli.Native
{
    [Flags]
    internal enum DeviceControlOptions : uint
    {
        DIGCF_DEFAULT = 0x1,
        DIGCF_PRESENT = 0x2,
        DIGCF_ALLCLASSES = 0x4,
        DIGCF_PROFILE = 0x8,
        DIGCF_DEVICEINTERFACE = 0x10
    }

}
