using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 0x50)]
    public struct HActRegister
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public char[] pad_0000; //0x0000
        public Vector4 position; //0x0010
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] pad_0020; //0x0020
        public int UIDSerial; //0x0024
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public char[] pad_0028; //0x0028
        public ushort rotY; //0x0038
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public char[] pad_003A; //0x003A
    }; //Size: 0x0050
}
