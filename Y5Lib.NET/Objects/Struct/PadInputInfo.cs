using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Y5Lib;

namespace Y5Lib
{
    // Created with ReClass.NET 1.2 by KN4CK3R

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PadInputInfo
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public fixed byte pad_0000[16]; //0x0000
        public Vector2 leftLever; //0x0010
        public Vector2 rightLever; //0x0018
        public fixed byte pad_0020[148]; //0x0020
    }; //Size: 0x00B4
}
