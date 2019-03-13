using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace CameraCli.Native
{
    internal static class DeviceManager
    {
        private static readonly string[] DeviceClassGuid = new string[63]
        {
            "{0x6bdd1fc1, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x66f250d6, 0x7801, 0x4a64, {0xb1, 0x39, 0xee, 0xa8, 0x0a, 0x45, 0x0b, 0x24}}",
            "{0x7ebefbc0, 0x3200, 0x11d2, {0xb4, 0xc2, 0x00, 0xa0, 0xc9, 0x69, 0x7d, 0x07}}",
            "{0x4d36e964, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0xd45b1c18, 0xc8fa, 0x11d1, {0x9f, 0x77, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}",
            "{0xc06ff265, 0xae09, 0x48f0, {0x81, 0x2c, 0x16, 0x75, 0x3d, 0x7c, 0xba, 0x83}}",
            "{0x72631e54, 0x78a4, 0x11d0, {0xbc, 0xf7, 0x00, 0xaa, 0x00, 0xb7, 0xb3, 0x2a}}",
            "{0x53d29ef7, 0x377c, 0x4d14, {0x86, 0x4b, 0xeb, 0x3a, 0x85, 0x76, 0x93, 0x59}}",
            "{0xe0cbf06c, 0xcd8b, 0x4647, {0xbb, 0x8a, 0x26, 0x3b, 0x43, 0xf0, 0xf9, 0x74}}",
            "{0x4d36e965, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e966, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x6bdd1fc2, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x4d36e967, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e968, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x48721b56, 0x6795, 0x11d2, {0xb1, 0xa8, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}",
            "{0x49ce6ac8, 0x6f86, 0x11d2, {0xb1, 0xe5, 0x00, 0x80, 0xc7, 0x2e, 0x74, 0xa2}}",
            "{0xc459df55, 0xdb08, 0x11d1, {0xb0, 0x09, 0x00, 0xa0, 0xc9, 0x08, 0x1f, 0xf6}}",
            "{0x4d36e969, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e980, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x6bdd1fc3, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x4d36e96a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x745a17a0, 0x74d3, 0x11d0, {0xb6, 0xfe, 0x00, 0xa0, 0xc9, 0x0f, 0x57, 0xda}}",
            "{0x6bdd1fc6, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x30ef7132, 0xd858, 0x4a0c, {0xac, 0x24, 0xb9, 0x02, 0x8a, 0x5c, 0xca, 0x3f}}",
            "{0x6bdd1fc5, 0x810f, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x4d36e96b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x8ecc055d, 0x047f, 0x11d1, {0xa5, 0x37, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xd1}}",
            "{0x4d36e96c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0xce5939ae, 0xebde, 0x11d0, {0xb1, 0x81, 0x00, 0x00, 0xf8, 0x75, 0x3e, 0xc4}}",
            "{0x5099944a, 0xf6b9, 0x4057, {0xa0, 0x56, 0x8c, 0x55, 0x02, 0x28, 0x54, 0x4c}}",
            "{0x4d36e96d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e96e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e96f, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e970, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e971, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x50906cb8, 0xba12, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}",
            "{0x4d36e972, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e973, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e974, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e975, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e976, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e977, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4658ee7e, 0xf050, 0x11d1, {0xb6, 0xbd, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}",
            "{0x4d36e978, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e979, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e97a, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x50127dc3, 0x0f36, 0x415e, {0xa6, 0xcc, 0x4c, 0xb3, 0xbe, 0x91, 0x0B, 0x65}}",
            "{0xd48179be, 0xec20, 0x11d1, {0xb6, 0xb8, 0x00, 0xc0, 0x4f, 0xa3, 0x72, 0xa7}}",
            "{0x4d36e97b, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x268c95a1, 0xedfe, 0x11d3, {0x95, 0xc3, 0x00, 0x10, 0xdc, 0x40, 0x50, 0xa5}}",
            "{0x5175d334, 0xc371, 0x4806, {0xb3, 0xba, 0x71, 0xfd, 0x53, 0xc9, 0x25, 0x8d}}",
            "{0x997b5d8d, 0xc442, 0x4f2e, {0xba, 0xf3, 0x9c, 0x8e, 0x67, 0x1e, 0x9e, 0x21}}",
            "{0x50dd5230, 0xba8a, 0x11d1, {0xbf, 0x5d, 0x00, 0x00, 0xf8, 0x05, 0xf5, 0x30}}",
            "{0x4d36e97c, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e97d, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x6d807884, 0x7d21, 0x11cf, {0x80, 0x1c, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x4d36e97e, 0xe325, 0x11ce, {0xbf, 0xc1, 0x08, 0x00, 0x2b, 0xe1, 0x03, 0x18}}",
            "{0x36fc9e60, 0xc465, 0x11cf, {0x80, 0x56, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00}}",
            "{0x71a27cdd, 0x812a, 0x11d0, {0xbe, 0xc7, 0x08, 0x00, 0x2b, 0xe2, 0x09, 0x2f}}",
            "{0x533c5b84, 0xec70, 0x11d2, {0x95, 0x05, 0x00, 0xc0, 0x4f, 0x79, 0xde, 0xaf}}",
            "{0x25dbce51, 0x6c8f, 0x4a72, {0x8a, 0x6d, 0xb5, 0x4c, 0x2b, 0x4f, 0xc8, 0x35}}",
            "{0xeec5ad98, 0x8080, 0x425f, {0x92, 0x2a, 0xda, 0xbf, 0x3d, 0xe3, 0xf6, 0x9a}}",
            "{0x9da2b80f, 0xf89f, 0x4a49, {0xa5, 0xc2, 0x51, 0x1b, 0x08, 0x5b, 0x9e, 0x8a}}"
        };

        public static void EnableDevice(Device TargetDevice) => ChangeDeviceState(TargetDevice, DeviceStateChange.DICS_ENABLE);

        public static void DisableDevice(Device TargetDevice) => ChangeDeviceState(TargetDevice, DeviceStateChange.DICS_DISABLE);

        private static void ChangeDeviceState(Device TargetDevice, DeviceStateChange StateChange)
        {
            Trace.TraceInformation("Entering ChangeDeviceState() for device '{0}' with state '{1}'", TargetDevice.InstanceId, StateChange);
            IntPtr deviceInfo = SetupApi.SetupDiGetClassDevs(IntPtr.Zero, TargetDevice.InstanceId, IntPtr.Zero, DeviceControlOptions.DIGCF_ALLCLASSES | DeviceControlOptions.DIGCF_DEVICEINTERFACE);
            if (deviceInfo == (IntPtr)(-1))
            {
                Trace.TraceError("Error calling SetupDiGetClassDevs() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
                throw new ArgumentException($"Invalid Device '{TargetDevice.InstanceId}'");
            }
            SP_DEVINFO_DATA deviceInfoData = default(SP_DEVINFO_DATA);
            deviceInfoData.cbSize = (uint)Marshal.SizeOf((object)deviceInfoData);
            if (!SetupApi.SetupDiEnumDeviceInfo(deviceInfo, 0u, ref deviceInfoData))
            {
                Trace.TraceError("Error calling SetupDiEnumDeviceInfo() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
                throw new Win32Exception("Error calling SetupDiEnumDeviceInfo()");
            }
            SP_CLASSINSTALL_HEADER installHeader = default(SP_CLASSINSTALL_HEADER);
            installHeader.InstallFunction = ClassInstallerFunctionCode.DIF_PROPERTYCHANGE;
            installHeader.cbSize = (uint)Marshal.SizeOf((object)installHeader);
            SP_PROPCHANGE_PARAMS propertyChangeParameters = default(SP_PROPCHANGE_PARAMS);
            propertyChangeParameters.ClassInstallHeader = installHeader;
            propertyChangeParameters.HwProfile = 0u;
            propertyChangeParameters.Scope = DeviceStateChangeScope.DICS_FLAG_GLOBAL;
            propertyChangeParameters.StateChange = StateChange;
            if (SetupApi.SetupDiSetClassInstallParams(deviceInfo, ref deviceInfoData, ref propertyChangeParameters, (uint)Marshal.SizeOf((object)propertyChangeParameters)))
            {
                if (!SetupApi.SetupDiCallClassInstaller(ClassInstallerFunctionCode.DIF_PROPERTYCHANGE, deviceInfo, ref deviceInfoData))
                {
                    Trace.TraceError("Error calling SetupDiCallClassInstaller() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
                    throw new Win32Exception("Error calling SetupDiCallClassInstaller()");
                }
            }
            else
            {
                Trace.TraceError("Error calling SetupDiSetClassInstallParams() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
            }
            if (!SetupApi.SetupDiDestroyDeviceInfoList(deviceInfo))
            {
                Trace.TraceError("Error calling SetupDiDestroyDeviceInfoList() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
            }
        }

        public static List<Device> ListDevices() => ListDevices(null, DeviceControlOptions.DIGCF_PRESENT | DeviceControlOptions.DIGCF_ALLCLASSES);

        public static List<Device> ListDevices(DeviceControlOptions flags) => ListDevices(null, flags);

        public static List<Device> ListDevices(DeviceClass deviceClass) => ListDevices(new Guid(DeviceClassGuid[(uint)deviceClass]), DeviceControlOptions.DIGCF_PRESENT);

        private static List<Device> ListDevices(Guid? deviceClass, DeviceControlOptions flags)
        {
            uint deviceInfoIterator = 0u;
            IntPtr deviceInfo;
            var devices = new List<Device>();

            if (deviceClass.HasValue)
            {
                GCHandle gch = GCHandle.Alloc(deviceClass, GCHandleType.Pinned);
                deviceInfo = SetupApi.SetupDiGetClassDevs(gch.AddrOfPinnedObject(), null, IntPtr.Zero, flags);
                gch.Free();
            }
            else
            {
                deviceInfo = SetupApi.SetupDiGetClassDevs(IntPtr.Zero, null, IntPtr.Zero, flags);
            }

            if (deviceInfo == (IntPtr)(-1))
            {
                Trace.TraceError("Error calling SetupDiGetClassDevs() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
            }
            else
            {
                SP_DEVINFO_DATA deviceInfoData = default(SP_DEVINFO_DATA);
                deviceInfoData.cbSize = (uint)Marshal.SizeOf((object)deviceInfoData);
                for (; SetupApi.SetupDiEnumDeviceInfo(deviceInfo, deviceInfoIterator, ref deviceInfoData); deviceInfoIterator++)
                {
                    Device d = new Device();
                    uint propertyCount = 0u;
                    SetupApi.SetupDiGetDevicePropertyKeys(deviceInfo, ref deviceInfoData, IntPtr.Zero, 0u, ref propertyCount, 0u);
                    DEVPROPKEY[] dev = new DEVPROPKEY[propertyCount];
                    GCHandle g = GCHandle.Alloc(dev, GCHandleType.Pinned);
                    if (!SetupApi.SetupDiGetDevicePropertyKeys(deviceInfo, ref deviceInfoData, g.AddrOfPinnedObject(), (uint)dev.Length, ref propertyCount, 0u))
                    {
                        Trace.TraceError("Error calling SetupDiGetDevicePropertyKeys() for {0} in order to get PropertyKeys - GetLastError: {1:X4}", deviceInfoData.InterfaceClassGuid, Marshal.GetLastWin32Error());
                        throw new Win32Exception("SetupDiGetDevicePropertyKeys()");
                    }
                    Trace.TraceInformation("SetupDiGetDevicePropertyKeys() returned '{0}' properties for device '{1}'", propertyCount, deviceInfoData.InterfaceClassGuid);
                    for (int devicePropertyIterator = 0; devicePropertyIterator < propertyCount; devicePropertyIterator++)
                    {
                        byte[] propBuffer = new byte[1];
                        uint requiredSize = 0u;
                        SetupApi.SetupDiGetDeviceProperty(deviceInfo, ref deviceInfoData, ref dev[devicePropertyIterator], out DEVPROPTYPE devicePropertyType, propBuffer, (uint)propBuffer.Length, ref requiredSize, 0u);
                        Array.Resize(ref propBuffer, (int)requiredSize);
                        if (!SetupApi.SetupDiGetDeviceProperty(deviceInfo, ref deviceInfoData, ref dev[devicePropertyIterator], out devicePropertyType, propBuffer, (uint)propBuffer.Length, ref requiredSize, 0u))
                        {
                            Trace.TraceError("Error calling SetupDiGetDeviceProperty() for {0} - GetLastError: {1:X4}", dev[devicePropertyIterator].fmtid, Marshal.GetLastWin32Error());
                            throw new Win32Exception("Error calling SetupDiGetDeviceProperty()");
                        }
                        switch (devicePropertyType)
                        {
                            case DEVPROPTYPE.DEVPROP_TYPE_STRING:
                                d.Properties.Add(dev[devicePropertyIterator], Encoding.Unicode.GetString(propBuffer, 0, (int)requiredSize));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_STRING_LIST:
                                {
                                    Dictionary<DEVPROPKEY, object> properties = d.Properties;
                                    DEVPROPKEY key = dev[devicePropertyIterator];
                                    string @string = Encoding.Unicode.GetString(propBuffer, 0, (int)requiredSize);
                                    char[] separator = new char[1];
                                    properties.Add(key, @string.Split(separator));
                                    break;
                                }
                            case DEVPROPTYPE.DEVPROP_TYPE_UINT16:
                                d.Properties.Add(dev[devicePropertyIterator], BitConverter.ToUInt16(propBuffer, 0));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_UINT32:
                                d.Properties.Add(dev[devicePropertyIterator], BitConverter.ToUInt32(propBuffer, 0));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_UINT64:
                                d.Properties.Add(dev[devicePropertyIterator], BitConverter.ToUInt64(propBuffer, 0));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_FILETIME:
                                d.Properties.Add(dev[devicePropertyIterator], DateTime.FromFileTime(BitConverter.ToInt64(propBuffer, 0)));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_BOOLEAN:
                                d.Properties.Add(dev[devicePropertyIterator], BitConverter.ToBoolean(propBuffer, 0));
                                break;
                            case DEVPROPTYPE.DEVPROP_TYPE_GUID:
                                {
                                    byte[] guidBuffer = new byte[16];
                                    Array.ConstrainedCopy(propBuffer, 0, guidBuffer, 0, 16);
                                    d.Properties.Add(dev[devicePropertyIterator], new Guid(guidBuffer));
                                    break;
                                }
                            case DEVPROPTYPE.DEVPROP_TYPE_INT32:
                                d.Properties.Add(dev[devicePropertyIterator], BitConverter.ToInt32(propBuffer, 0));
                                break;
                            default:
                                Trace.TraceWarning("No property processing available for devicePropertyType for fmtid: {0}, pid: {1} and devicePropertyType: {2}", dev[devicePropertyIterator].fmtid, dev[devicePropertyIterator].pid, devicePropertyType);
                                break;
                        }
                    }
                    g.Free();
                    devices.Add(d);
                }
            }
            if (!SetupApi.SetupDiDestroyDeviceInfoList(deviceInfo))
            {
                Trace.TraceError("Error calling SetupDiDestroyDeviceInfoList() - GetLastError: {0:X4}", Marshal.GetLastWin32Error());
            }
            // return (int)deviceInfoIterator;
            return devices;
        }
    }
}
