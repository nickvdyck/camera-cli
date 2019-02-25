using System;

namespace CameraCli.Devices
{

    [Flags]
    internal enum DeviceStateChangeScope : uint
    {
        DICS_FLAG_GLOBAL = 0x1,
        DICS_FLAG_CONFIGSPECIFIC = 0x2,
        DICS_FLAG_CONFIGGENERAL = 0x4
    }
}