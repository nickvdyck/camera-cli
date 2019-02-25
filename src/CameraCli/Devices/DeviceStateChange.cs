using System;

namespace CameraCli.Devices
{
    [Flags]
    internal enum DeviceStateChange : uint
    {
        DICS_ENABLE = 0x1,
        DICS_DISABLE = 0x2,
        DICS_PROPCHANGE = 0x3,
        DICS_START = 0x4,
        DICS_STOP = 0x5
    }

}