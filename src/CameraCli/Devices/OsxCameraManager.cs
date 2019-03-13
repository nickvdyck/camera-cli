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

        public List<Camera> List()
        {
            var camera = new Camera()
            {
                Name = "FaceTime Camera",
                Enabled = false,
            };

            foreach (var cameraFd in _cameraFDs)
            {
                Syscall.stat(cameraFd, out var buffer);
                var current = buffer.st_mode;

                if (
                    buffer.st_mode.HasFlag(FilePermissions.S_IRUSR) &&
                    buffer.st_mode.HasFlag(FilePermissions.S_IRGRP) &&
                    buffer.st_mode.HasFlag(FilePermissions.S_IROTH)
                )
                {
                    camera.Enabled = true;
                    break;
                }
            }

            return new List<Camera> { camera };
        }

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
                throw new Exception(error);
            }

            process.WaitForExit();
            return output;
        }

        public void Enable()
        {
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
                    else
                    {
                        throw new Exception(errno.ToString());
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

                if (result == -1)
                {
                    var errno = Syscall.GetLastError();

                    if (errno == Errno.EPERM)
                    {
                        throw new UnauthorizedAccessException();
                    }
                    else
                    {
                        throw new Exception(errno.ToString());
                    }
                }
            }
        }
    }
}
