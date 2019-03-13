using Mono.Unix.Native;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace CameraCli.Utils
{
    public static class CurrentUser
    {
        public static bool IsAdminOrRoot()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return IsAdmin();
            }

            return IsRoot();
        }

        private static bool IsAdmin()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private static bool IsRoot() => Syscall.geteuid() == 0;
    }
}
