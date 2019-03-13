using System.Collections.Generic;

namespace CameraCli.Devices
{
    public interface ICameraManager
    {
        string UsedBy();

        List<Camera> List();

        void Enable();

        void Disable();
    }
}
