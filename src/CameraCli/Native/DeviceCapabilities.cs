using System;

namespace CameraCli.Native
{
    [Flags]
    public enum DeviceCapabilities : uint
    {
        CM_DEVCAP_LOCKSUPPORTED = 0x1,
        CM_DEVCAP_EJECTSUPPORTED = 0x2,
        CM_DEVCAP_REMOVABLE = 0x4,
        CM_DEVCAP_DOCKDEVICE = 0x8,
        CM_DEVCAP_UNIQUEID = 0x10,
        CM_DEVCAP_SILENTINSTALL = 0x20,
        CM_DEVCAP_RAWDEVICEOK = 0x40,
        CM_DEVCAP_SURPRISEREMOVALOK = 0x80,
        CM_DEVCAP_HARDWAREDISABLED = 0x100,
        CM_DEVCAP_NONDYNAMIC = 0x200
    }

}
