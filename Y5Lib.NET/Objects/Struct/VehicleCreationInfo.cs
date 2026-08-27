using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Explicit, Size = 228)]
    public struct VehicleCreationInfo
    {
        [FieldOffset(0)]
        public int unknown; //0x0000
        [FieldOffset(4)]
        public int VehicleType; //0x0004
        [FieldOffset(8)]
        public int unknown3; //0x0008
        [FieldOffset(0xC)]
        public VehiclePassengerData Driver;
        [FieldOffset(0x54)]
        public VehiclePassengerData Passenger1;
        [FieldOffset(0x9C)]
        public VehiclePassengerData Passenger2;
    }
}
