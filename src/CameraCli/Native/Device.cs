using System.Collections.Generic;

namespace CameraCli.Native
{
    public class Device
    {
        internal static readonly Dictionary<string, DEVPROPKEY> DEVPKEY = new Dictionary<string, DEVPROPKEY>
        {
            {
                "DEVPKEY_NAME",
                new DEVPROPKEY("{0xb725f130, 0x47ef, 0x101a, {0xa5, 0xf1, 0x02, 0x60, 0x8c, 0x9e, 0xeb, 0xac}}", 10u)
            },
            {
                "DEVPKEY_Device_DeviceDesc",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 2u)
            },
            {
                "DEVPKEY_Device_HardwareIds",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 3u)
            },
            {
                "DEVPKEY_Device_CompatibleIds",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 4u)
            },
            {
                "DEVPKEY_Device_Service",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 6u)
            },
            {
                "DEVPKEY_Device_Class",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 9u)
            },
            {
                "DEVPKEY_Device_ClassGuid",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 10u)
            },
            {
                "DEVPKEY_Device_Driver",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 11u)
            },
            {
                "DEVPKEY_Device_ConfigFlags",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 12u)
            },
            {
                "DEVPKEY_Device_Manufacturer",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 13u)
            },
            {
                "DEVPKEY_Device_FriendlyName",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 14u)
            },
            {
                "DEVPKEY_Device_LocationInfo",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 15u)
            },
            {
                "DEVPKEY_Device_PDOName",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 16u)
            },
            {
                "DEVPKEY_Device_Capabilities",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 17u)
            },
            {
                "DEVPKEY_Device_UINumber",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 18u)
            },
            {
                "DEVPKEY_Device_UpperFilters",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 19u)
            },
            {
                "DEVPKEY_Device_LowerFilters",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 20u)
            },
            {
                "DEVPKEY_Device_BusTypeGd",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 21u)
            },
            {
                "DEVPKEY_Device_LegacyBusType",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 22u)
            },
            {
                "DEVPKEY_Device_BusNumber",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 23u)
            },
            {
                "DEVPKEY_Device_EnumeratorName",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 24u)
            },
            {
                "DEVPKEY_Device_Security",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 25u)
            },
            {
                "DEVPKEY_Device_SecuritySDS",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 26u)
            },
            {
                "DEVPKEY_Device_DevType",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 27u)
            },
            {
                "DEVPKEY_Device_Exclusive",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 28u)
            },
            {
                "DEVPKEY_Device_Characteristics",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 29u)
            },
            {
                "DEVPKEY_Device_Address",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 30u)
            },
            {
                "DEVPKEY_Device_UINumberDescFormat",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 31u)
            },
            {
                "DEVPKEY_Device_PowerData",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 32u)
            },
            {
                "DEVPKEY_Device_RemovalPolicy",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 33u)
            },
            {
                "DEVPKEY_Device_RemovalPolicyDefault",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 34u)
            },
            {
                "DEVPKEY_Device_RemovalPolicyOverride",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 35u)
            },
            {
                "DEVPKEY_Device_InstallState",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 36u)
            },
            {
                "DEVPKEY_Device_LocationPaths",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 37u)
            },
            {
                "DEVPKEY_Device_BaseContainerId",
                new DEVPROPKEY("{0xa45c254e, 0xdf1c, 0x4efd, {0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0}}", 38u)
            },
            {
                "DEVPKEY_Device_DevNodeStatus",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 2u)
            },
            {
                "DEVPKEY_Device_ProblemCode",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 3u)
            },
            {
                "DEVPKEY_Device_EjectionRelations",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 4u)
            },
            {
                "DEVPKEY_Device_RemovalRelations",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 5u)
            },
            {
                "DEVPKEY_Device_PowerRelations",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 6u)
            },
            {
                "DEVPKEY_Device_BusRelations",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 7u)
            },
            {
                "DEVPKEY_Device_Parent",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 8u)
            },
            {
                "DEVPKEY_Device_Children",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 9u)
            },
            {
                "DEVPKEY_Device_Siblings",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 10u)
            },
            {
                "DEVPKEY_Device_TransportRelations",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 11u)
            },
            {
                "DEVPKEY_Device_ProblemStatus",
                new DEVPROPKEY("{0x4340a6c5, 0x93fa, 0x4706, {0x97, 0x2c, 0x7b, 0x64, 0x80, 0x08, 0xa5, 0xa7}}", 12u)
            },
            {
                "DEVPKEY_Device_Reported",
                new DEVPROPKEY("{0x80497100, 0x8c73, 0x48b9, {0xaa, 0xd9, 0xce, 0x38, 0x7e, 0x19, 0xc5, 0x6e}}", 2u)
            },
            {
                "DEVPKEY_Device_Legacy",
                new DEVPROPKEY("{0x80497100, 0x8c73, 0x48b9, {0xaa, 0xd9, 0xce, 0x38, 0x7e, 0x19, 0xc5, 0x6e}}", 3u)
            },
            {
                "DEVPKEY_Device_ContainerId",
                new DEVPROPKEY("{0x8c7ed206, 0x3f8a, 0x4827, {0xb3, 0xab, 0xae, 0x9e, 0x1f, 0xae, 0xfc, 0x6c}}", 2u)
            },
            {
                "DEVPKEY_Device_InLocalMachineContainer",
                new DEVPROPKEY("{ 0x8c7ed206, 0x3f8a, 0x4827, {0xb3, 0xab, 0xae, 0x9e, 0x1f, 0xae, 0xfc, 0x6c}}", 4u)
            },
            {
                "DEVPKEY_Device_ModelId",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 2u)
            },
            {
                "DEVPKEY_Device_FriendlyNameAttributes",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 3u)
            },
            {
                "DEVPKEY_Device_ManufacturerAttributes",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 4u)
            },
            {
                "DEVPKEY_Device_PresenceNotForDevice",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 5u)
            },
            {
                "DEVPKEY_Device_SignalStrength",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 6u)
            },
            {
                "DEVPKEY_Device_IsAssociateableByUserAction",
                new DEVPROPKEY("{0x80d81ea6, 0x7473, 0x4b0c, {0x82, 0x16, 0xef, 0xc1, 0x1a, 0x2c, 0x4c, 0x8b}}", 7u)
            },
            {
                "DEVPKEY_Numa_Proximity_Domain",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 1u)
            },
            {
                "DEVPKEY_Device_DHP_Rebalance_Policy",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 2u)
            },
            {
                "DEVPKEY_Device_Numa_Node",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 3u)
            },
            {
                "DEVPKEY_Device_BusReportedDeviceDesc",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 4u)
            },
            {
                "DEVPKEY_Device_IsPresent",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 5u)
            },
            {
                "DEVPKEY_Device_HasProblem",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 6u)
            },
            {
                "DEVPKEY_Device_ConfigurationId",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 7u)
            },
            {
                "DEVPKEY_Device_ReportedDeviceIdsHash",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 8u)
            },
            {
                "DEVPKEY_Device_PhysicalDeviceLocation",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 9u)
            },
            {
                "DEVPKEY_Device_BiosDeviceName",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 10u)
            },
            {
                "DEVPKEY_Device_DriverProblemDesc",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 11u)
            },
            {
                "DEVPKEY_Device_DebuggerSafe",
                new DEVPROPKEY("{0x540b947e, 0x8b40, 0x45bc, {0xa8, 0xa2, 0x6a, 0x0b, 0x89, 0x4c, 0xbd, 0xa2}}", 12u)
            },
            {
                "DEVPKEY_Device_SessionId",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 6u)
            },
            {
                "DEVPKEY_Device_InstallDate",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 100u)
            },
            {
                "DEVPKEY_Device_FirstInstallDate",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 101u)
            },
            {
                "DEVPKEY_Device_LastArrivalDate",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 102u)
            },
            {
                "DEVPKEY_Device_LastRemovalDate",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 103u)
            },
            {
                "DEVPKEY_Device_DriverDate",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 2u)
            },
            {
                "DEVPKEY_Device_DriverVersion",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 3u)
            },
            {
                "DEVPKEY_Device_DriverDesc",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 4u)
            },
            {
                "DEVPKEY_Device_DriverInfPath",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 5u)
            },
            {
                "DEVPKEY_Device_DriverInfSection",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 6u)
            },
            {
                "DEVPKEY_Device_DriverInfSectionExt",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 7u)
            },
            {
                "DEVPKEY_Device_MatchingDeviceId",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 8u)
            },
            {
                "DEVPKEY_Device_DriverProvider",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 9u)
            },
            {
                "DEVPKEY_Device_DriverPropPageProvider",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 10u)
            },
            {
                "DEVPKEY_Device_DriverCoInstallers",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 11u)
            },
            {
                "DEVPKEY_Device_ResourcePickerTags",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 12u)
            },
            {
                "DEVPKEY_Device_ResourcePickerExceptions",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 13u)
            },
            {
                "DEVPKEY_Device_DriverRank",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 14u)
            },
            {
                "DEVPKEY_Device_DriverLogoLevel",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 15u)
            },
            {
                "DEVPKEY_Device_NoConnectSound",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 17u)
            },
            {
                "DEVPKEY_Device_GenericDriverInstalled",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 18u)
            },
            {
                "DEVPKEY_Device_AdditionalSoftwareRequested",
                new DEVPROPKEY("{0xa8b865dd, 0x2e3d, 0x4094, {0xad, 0x97, 0xe5, 0x93, 0xa7, 0xc, 0x75, 0xd6}}", 19u)
            },
            {
                "DEVPKEY_Device_SafeRemovalRequired",
                new DEVPROPKEY("{0xafd97640,  0x86a3, 0x4210, {0xb6, 0x7c, 0x28, 0x9c, 0x41, 0xaa, 0xbe, 0x55}}", 2u)
            },
            {
                "DEVPKEY_Device_SafeRemovalRequiredOverride",
                new DEVPROPKEY("{0xafd97640,  0x86a3, 0x4210, {0xb6, 0x7c, 0x28, 0x9c, 0x41, 0xaa, 0xbe, 0x55}}", 3u)
            },
            {
                "DEVPKEY_DrvPkg_Model",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 2u)
            },
            {
                "DEVPKEY_DrvPkg_VendorWebSite",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 3u)
            },
            {
                "DEVPKEY_DrvPkg_DetailedDescription",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 4u)
            },
            {
                "DEVPKEY_DrvPkg_DocumentationLink",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 5u)
            },
            {
                "DEVPKEY_DrvPkg_Icon",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 6u)
            },
            {
                "DEVPKEY_DrvPkg_BrandingIcon",
                new DEVPROPKEY("{0xcf73bb51, 0x3abf, 0x44a2, {0x85, 0xe0, 0x9a, 0x3d, 0xc7, 0xa1, 0x21, 0x32}}", 7u)
            },
            {
                "DEVPKEY_DeviceClass_UpperFilters",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 19u)
            },
            {
                "DEVPKEY_DeviceClass_LowerFilters",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 20u)
            },
            {
                "DEVPKEY_DeviceClass_Security",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 25u)
            },
            {
                "DEVPKEY_DeviceClass_SecuritySDS",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 26u)
            },
            {
                "DEVPKEY_DeviceClass_DevType",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 27u)
            },
            {
                "DEVPKEY_DeviceClass_Exclusive",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 28u)
            },
            {
                "DEVPKEY_DeviceClass_Characteristics",
                new DEVPROPKEY("{0x4321918b, 0xf69e, 0x470d, {0xa5, 0xde, 0x4d, 0x88, 0xc7, 0x5a, 0xd2, 0x4b}}", 29u)
            },
            {
                "DEVPKEY_DeviceClass_Name",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 2u)
            },
            {
                "DEVPKEY_DeviceClass_ClassName",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 3u)
            },
            {
                "DEVPKEY_DeviceClass_Icon",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 4u)
            },
            {
                "DEVPKEY_DeviceClass_ClassInstaller",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 5u)
            },
            {
                "DEVPKEY_DeviceClass_PropPageProvider",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 6u)
            },
            {
                "DEVPKEY_DeviceClass_NoInstallClass",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 7u)
            },
            {
                "DEVPKEY_DeviceClass_NoDisplayClass",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 8u)
            },
            {
                "DEVPKEY_DeviceClass_SilentInstall",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 9u)
            },
            {
                "DEVPKEY_DeviceClass_NoUseClass",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 10u)
            },
            {
                "DEVPKEY_DeviceClass_DefaultService",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 11u)
            },
            {
                "DEVPKEY_DeviceClass_IconPath",
                new DEVPROPKEY("{0x259abffc, 0x50a7, 0x47ce, {0xaf, 0x8, 0x68, 0xc9, 0xa7, 0xd7, 0x33, 0x66}}", 12u)
            },
            {
                "DEVPKEY_DeviceClass_DHPRebalanceOptOut",
                new DEVPROPKEY("{0xd14d3ef3, 0x66cf, 0x4ba2, {0x9d, 0x38, 0x0d, 0xdb, 0x37, 0xab, 0x47, 0x01}}", 2u)
            },
            {
                "DEVPKEY_DeviceClass_ClassCoInstallers",
                new DEVPROPKEY("{0x713d1703, 0xa2e2, 0x49f5, {0x92, 0x14, 0x56, 0x47, 0x2e, 0xf3, 0xda, 0x5c}}", 2u)
            },
            {
                "DEVPKEY_DeviceInterface_FriendlyName",
                new DEVPROPKEY("{0x026e516e, 0xb814, 0x414b, {0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22}}", 2u)
            },
            {
                "DEVPKEY_DeviceInterface_Enabled",
                new DEVPROPKEY("{0x026e516e, 0xb814, 0x414b, {0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22}}", 3u)
            },
            {
                "DEVPKEY_DeviceInterface_ClassGuid",
                new DEVPROPKEY("{0x026e516e, 0xb814, 0x414b, {0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22}}", 4u)
            },
            {
                "DEVPKEY_DeviceInterface_ReferenceString",
                new DEVPROPKEY("{0x026e516e, 0xb814, 0x414b, {0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22}}", 5u)
            },
            {
                "DEVPKEY_DeviceInterface_Restricted",
                new DEVPROPKEY("{0x026e516e, 0xb814, 0x414b, {0x83, 0xcd, 0x85, 0x6d, 0x6f, 0xef, 0x48, 0x22}}", 6u)
            },
            {
                "DEVPKEY_DeviceInterfaceClass_DefaultInterface",
                new DEVPROPKEY("{0x14c83a99, 0x0b3f, 0x44b7, {0xbe, 0x4c, 0xa1, 0x78, 0xd3, 0x99, 0x05, 0x64}}", 2u)
            },
            {
                "DEVPKEY_DeviceInterfaceClass_Name",
                new DEVPROPKEY("{0x14c83a99, 0x0b3f, 0x44b7, {0xbe, 0x4c, 0xa1, 0x78, 0xd3, 0x99, 0x05, 0x64}}", 3u)
            },
            {
                "DEVPKEY_Device_Model",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 39u)
            },
            {
                "DEVPKEY_DeviceContainer_Address",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 51u)
            },
            {
                "DEVPKEY_DeviceContainer_DiscoveryMethod",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 52u)
            },
            {
                "DEVPKEY_DeviceContainer_IsEncrypted",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 53u)
            },
            {
                "DEVPKEY_DeviceContainer_IsAuthenticated",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 54u)
            },
            {
                "DEVPKEY_DeviceContainer_IsConnected",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 55u)
            },
            {
                "DEVPKEY_DeviceContainer_IsPaired",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 56u)
            },
            {
                "DEVPKEY_DeviceContainer_Icon",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 57u)
            },
            {
                "DEVPKEY_DeviceContainer_Version",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 65u)
            },
            {
                "DEVPKEY_DeviceContainer_Last_Seen",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 66u)
            },
            {
                "DEVPKEY_DeviceContainer_Last_Connected",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 67u)
            },
            {
                "DEVPKEY_DeviceContainer_IsShowInDisconnectedState",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 68u)
            },
            {
                "DEVPKEY_DeviceContainer_IsLocalMachine",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 70u)
            },
            {
                "DEVPKEY_DeviceContainer_MetadataPath",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 71u)
            },
            {
                "DEVPKEY_DeviceContainer_IsMetadataSearchInProgress",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 72u)
            },
            {
                "DEVPKEY_DeviceContainer_MetadataChecksum",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 73u)
            },
            {
                "DEVPKEY_DeviceContainer_IsNotInterestingForDisplay",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 74u)
            },
            {
                "DEVPKEY_DeviceContainer_LaunchDeviceStageOnDeviceConnect",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 76u)
            },
            {
                "DEVPKEY_DeviceContainer_LaunchDeviceStageFromExplorer",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 77u)
            },
            {
                "DEVPKEY_DeviceContainer_BaselineExperienceId",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 78u)
            },
            {
                "DEVPKEY_DeviceContainer_IsDeviceUniquelyIdentifiable",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 79u)
            },
            {
                "DEVPKEY_DeviceContainer_AssociationArray",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 80u)
            },
            {
                "DEVPKEY_DeviceContainer_DeviceDescription1",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 81u)
            },
            {
                "DEVPKEY_DeviceContainer_DeviceDescription2",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 82u)
            },
            {
                "DEVPKEY_DeviceContainer_HasProblem",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 83u)
            },
            {
                "DEVPKEY_DeviceContainer_IsSharedDevice",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 84u)
            },
            {
                "DEVPKEY_DeviceContainer_IsNetworkDevice",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 85u)
            },
            {
                "DEVPKEY_DeviceContainer_IsDefaultDevice",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 86u)
            },
            {
                "DEVPKEY_DeviceContainer_MetadataCabinet",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 87u)
            },
            {
                "DEVPKEY_DeviceContainer_RequiresPairingElevation",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 88u)
            },
            {
                "DEVPKEY_DeviceContainer_ExperienceId",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 89u)
            },
            {
                "DEVPKEY_DeviceContainer_Category",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 90u)
            },
            {
                "DEVPKEY_DeviceContainer_Category_Desc_Singular",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 91u)
            },
            {
                "DEVPKEY_DeviceContainer_Category_Desc_Plural",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 92u)
            },
            {
                "DEVPKEY_DeviceContainer_Category_Icon",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 93u)
            },
            {
                "DEVPKEY_DeviceContainer_CategoryGroup_Desc",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 94u)
            },
            {
                "DEVPKEY_DeviceContainer_CategoryGroup_Icon",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 95u)
            },
            {
                "DEVPKEY_DeviceContainer_PrimaryCategory",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 97u)
            },
            {
                "DEVPKEY_DeviceContainer_UnpairUninstall",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 98u)
            },
            {
                "DEVPKEY_DeviceContainer_RequiresUninstallElevation",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 99u)
            },
            {
                "DEVPKEY_DeviceContainer_DeviceFunctionSubRank",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 100u)
            },
            {
                "DEVPKEY_DeviceContainer_AlwaysShowDeviceAsConnected",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 101u)
            },
            {
                "DEVPKEY_DeviceContainer_ConfigFlags",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 105u)
            },
            {
                "DEVPKEY_DeviceContainer_PrivilegedPackageFamilyNames",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 106u)
            },
            {
                "DEVPKEY_DeviceContainer_CustomPrivilegedPackageFamilyNames",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 107u)
            },
            {
                "DEVPKEY_DeviceContainer_IsRebootRequired",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 108u)
            },
            {
                "DEVPKEY_Device_InstanceId",
                new DEVPROPKEY("{0x78c34fc8, 0x104a, 0x4aca, {0x9e, 0xa4, 0x52, 0x4d, 0x52, 0x99, 0x6e, 0x57}}", 256u)
            },
            {
                "DEVPKEY_DeviceContainer_FriendlyName",
                new DEVPROPKEY("{0x656A3BB3, 0xECC0, 0x43FD, {0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD}}", 12288u)
            },
            {
                "DEVPKEY_DeviceContainer_Manufacturer",
                new DEVPROPKEY("{0x656A3BB3, 0xECC0, 0x43FD, {0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD}}", 8192u)
            },
            {
                "DEVPKEY_DeviceContainer_ModelName",
                new DEVPROPKEY("{0x656A3BB3, 0xECC0, 0x43FD, {0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD}}", 8194u)
            },
            {
                "DEVPKEY_DeviceContainer_ModelNumber",
                new DEVPROPKEY("{0x656A3BB3, 0xECC0, 0x43FD, {0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD}}", 8195u)
            },
            {
                "DEVPKEY_DeviceContainer_InstallInProgress",
                new DEVPROPKEY("{0x83da6326, 0x97a6, 0x4088, {0x94, 0x53, 0xa1, 0x92, 0x3f, 0x57, 0x3b, 0x29}}", 9u)
            }
        };

        internal Dictionary<DEVPROPKEY, object> Properties = new Dictionary<DEVPROPKEY, object>();

        public string Name => (string) GetProperty("DEVPKEY_NAME");

        public DeviceCapabilities Capabilities
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_Capabilities");
                if (o == null)
                {
                    return (DeviceCapabilities)0u;
                }
                return (DeviceCapabilities)o;
            }
        }

        public DeviceConfigurationFlags ConfigurationFlags
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_ConfigFlags");
                if (o == null)
                {
                    return (DeviceConfigurationFlags)0u;
                }
                return (DeviceConfigurationFlags)o;
            }
        }

        public DeviceInstallState InstallState
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_InstallState");
                if (o == null)
                {
                    return DeviceInstallState.InstallStateInstalled;
                }
                return (DeviceInstallState)o;
            }
        }

        public uint NumaNode
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_Numa_Node");
                if (o == null)
                {
                    return 0u;
                }
                return (uint)o;
            }
        }

        public uint UINumber
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_UINumber");
                if (o == null)
                {
                    return 0u;
                }
                return (uint)o;
            }
        }

        public DeviceCharacteristics Characteristics
        {
            get
            {
                object o = GetProperty("DEVPKEY_Device_Characteristics");
                if (o == null)
                {
                    return (DeviceCharacteristics)0u;
                }
                return (DeviceCharacteristics)o;
            }
        }

        public string Manufacturer => (string)GetProperty("DEVPKEY_Device_Manufacturer");

        public string[] HardwareIds => (string[])GetProperty("DEVPKEY_Device_HardwareIds");

        public string[] LocationPaths => (string[])GetProperty("DEVPKEY_Device_LocationPaths");

        public string DriverVersion => (string)GetProperty("DEVPKEY_Device_DriverVersion");

        public string DriverProvider => (string)GetProperty("DEVPKEY_Device_DriverProvider");

        public string DriverDescription => (string)GetProperty("DEVPKEY_Device_DriverDesc");

        public string LocationInfo => (string)GetProperty("DEVPKEY_Device_LocationInfo");

        public string InstanceId => (string)GetProperty("DEVPKEY_Device_InstanceId");

        public string Service => (string)GetProperty("DEVPKEY_Device_Service");

        public string DeviceParent => (string)GetProperty("DEVPKEY_Device_Parent");

        public string[] DeviceSiblings => (string[])GetProperty("DEVPKEY_Device_Siblings");

        public bool IsPresent => (bool)GetProperty("DEVPKEY_Device_IsPresent");

        public bool HasProblem => (bool)GetProperty("DEVPKEY_Device_HasProblem");

        public string PhysicalDeviceObjectName => (string)GetProperty("DEVPKEY_Device_PDOName");

        public Dictionary<string, object> AvailableProperties
        {
            get
            {
                Dictionary<string, object> props = new Dictionary<string, object>();
                foreach (string key in DEVPKEY.Keys)
                {
                    DEVPKEY.TryGetValue(key, out DEVPROPKEY d);
                    if (Properties.TryGetValue(d, out object o))
                    {
                        props.Add(key, o);
                    }
                }
                return props;
            }
        }

        private object GetProperty(string propertyName)
        {
            DEVPKEY.TryGetValue(propertyName, out DEVPROPKEY d);
            Properties.TryGetValue(d, out object o);
            return o;
        }
    }
}
