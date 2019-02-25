using System;
using System.Runtime.InteropServices;

namespace CameraCli.Devices
{
    internal struct SP_DEVINFO_DATA
    {
        public uint cbSize;

        public Guid InterfaceClassGuid;

        public uint DevInst;

        public UIntPtr Reserved;
    }

}