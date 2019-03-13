using System;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;

namespace CameraCli.Devices
{
    public static class CameraManagerExtensions
    {
        public static IServiceCollection AddCameraManager(this IServiceCollection services)
        {
            services.AddSingleton<ICameraManager>(_ =>
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return new WindowsCameraManager();
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return new OsxCameraManager();
                }

                throw new PlatformNotSupportedException();
            });

            return services;
        }
    }
}
