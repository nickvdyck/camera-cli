namespace CameraCli.Devices
{
    public enum DeviceInstallState : uint
    {
        InstallStateInstalled,
        InstallStateNeedsReinstall,
        InstallStateFailedInstall,
        InstallStateFinishInstall
    }

}