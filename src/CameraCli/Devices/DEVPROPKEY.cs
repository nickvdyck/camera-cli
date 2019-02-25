using System;

namespace CameraCli.Devices
{

    internal struct DEVPROPKEY
    {
        public Guid fmtid;

        public uint pid;

        public DEVPROPKEY(string strGuid, uint id)
        {
            fmtid = new Guid(strGuid);
            pid = id;
        }
    }

}