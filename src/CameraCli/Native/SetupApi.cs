using System;
using System.Runtime.InteropServices;

namespace CameraCli.Native
{
    public static class SetupApi
    {

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SetupDiGetClassDevs(
            [In] IntPtr classGuid,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string enumerator,
            [In] IntPtr hwndParent,
            DeviceControlOptions Flags
        );

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetupDiEnumDeviceInfo(
            IntPtr DeviceInfoSet,
            uint MemberIndex,
            ref SP_DEVINFO_DATA DeviceInfoData
        );

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetupDiSetClassInstallParams(
            [In] IntPtr DeviceInfoSet,
            [In] ref SP_DEVINFO_DATA DeviceInfoData,
            [In] ref SP_PROPCHANGE_PARAMS ClassInstallParams,
            uint ClassInstallParamsSize
        );


        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetupDiCallClassInstaller(
            ClassInstallerFunctionCode InstallFunction,
            [In] IntPtr DeviceInfoSet,
            [In] ref SP_DEVINFO_DATA DeviceInfoData
        );

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetupDiGetDevicePropertyKeys(IntPtr DeviceInfoSet, ref SP_DEVINFO_DATA DeviceInfoData, IntPtr PropertyKeyArray, uint PropertyKeyCount, ref uint RequiredPropertyKeyCount, uint Flags);

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetupDiGetDeviceProperty(IntPtr DeviceInfoSet, [In] ref SP_DEVINFO_DATA DeviceInfoData, [In] ref DEVPROPKEY PropertyKey, out DEVPROPTYPE PropertyType, byte[] PropertyBuffer, uint PropertyBufferSize, ref uint RequiredSize, uint Flags);

    }
}
