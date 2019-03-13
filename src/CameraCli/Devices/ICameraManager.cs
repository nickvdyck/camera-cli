namespace CameraCli.Devices
{
    public interface ICameraManager
    {
        string UsedBy();

        void Enable();

        void Disable();
    }
}
