using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public struct HActPlayData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public char[] pad_0000; //0x0000
        public int hactID; //0x0010
        public int N0001338F; //0x0014
        ChecksumString hactName; //0x0018
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        char[] pad_0038; //0x0038
        Matrix4x4 transform; //0x0060
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] pad_00A0; //0x00A0
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public HActRegister[] registers; //0x00C0
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 176)]
        public char[] pad_0AC0; //0x0AC0
    }; //Size: 0x0B70
}
