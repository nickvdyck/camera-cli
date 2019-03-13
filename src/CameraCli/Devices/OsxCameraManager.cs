using Mono.Unix.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CameraCli.Devices
{
    public class OsxCameraManager : ICameraManager
    {
        private const string VDC_CAMERA = "/System/Library/Frameworks/CoreMediaIO.framework/Versions/A/Resources/VDC.plugin/Contents/MacOS/VDC";
        private const string AVC_CAMERA = "/System/Library/PrivateFrameworks/CoreMediaIOServicesPrivate.framework/Versions/A/Resources/AVC.plugin/Contents/MacOS/AVC";
        private const string APPLE_CAMERA_DAL = "/Library/CoreMediaIO/Plug-Ins/DAL/AppleCamera.plugin/Contents/MacOS/AppleCamera";
        private const string APPLE_CAMERA_FCP = "/Library/CoreMediaIO/Plug-Ins/FCP-DAL/AppleCamera.plugin/Contents/MacOS/AppleCamera";

        private readonly List<string> _cameraFDs = new List<string>() { APPLE_CAMERA_DAL, APPLE_CAMERA_FCP };
        public string UsedBy()
        {
            var process = new Process
            {
                StartInfo =
                {
                    FileName = "bash",
                    Arguments = "-c \"lsof | grep -w 'AppleCamera\\|USBVDC\\|iSight' | awk '{printf $2 \\\"\\\n\\\"}' | xargs ps\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };
            process.Start();

            var output = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();

            if (!String.IsNullOrEmpty(error))
            {
                System.Console.WriteLine($"ERROR: {error}");
            }

            process.WaitForExit();
            return output;
        }

        public void Enable()
        {
            //    #define S_IRWXU 0000700    /* RWX mask for owner */
            //    #define S_IRUSR 0000400    /* R for owner */
            //    #define S_IWUSR 0000200    /* W for owner */
            //    #define S_IXUSR 0000100    /* X for owner */

            //    #define S_IRWXG 0000070    /* RWX mask for group */
            //    #define S_IRGRP 0000040    /* R for group */
            //    #define S_IWGRP 0000020    /* W for group */
            //    #define S_IXGRP 0000010    /* X for group */
            //    #define S_IRWXO 0000007    /* RWX mask for other */
            //    #define S_IROTH 0000004    /* R for other */
            //    #define S_IWOTH 0000002    /* W for other */
            //    #define S_IXOTH 0000001    /* X for other */

            foreach (var cameraFd in _cameraFDs)
            {
                Syscall.stat(cameraFd, out var buffer);
                var current = buffer.st_mode;
                var after = current | FilePermissions.S_IRUSR | FilePermissions.S_IRGRP | FilePermissions.S_IROTH;

                var result = Syscall.chmod(cameraFd, after);

                if (result == -1)
                {
                    var errno = Syscall.GetLastError();

                    if (errno == Errno.EPERM)
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
            }
        }

        public void Disable()
        {
            foreach (var cameraFd in _cameraFDs)
            {
                Syscall.stat(cameraFd, out var buffer);
                var current = buffer.st_mode;
                var after = current & ~FilePermissions.S_IRUSR & ~FilePermissions.S_IRGRP & ~FilePermissions.S_IROTH;

                var result = Syscall.chmod(cameraFd, after);
                System.Console.WriteLine(current);
                System.Console.WriteLine(after);

                // var result = 0;

                if (result == -1)
                {
                    var errno = Syscall.GetLastError();

                    if (errno == Errno.EPERM)
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
            }
        }
    }
}
