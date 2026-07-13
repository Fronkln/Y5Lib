using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe struct MsgEntityHeader
    {
        public int entityUID; //0x0000
        public int msgDataRelPointer; //0x0004
        public int entityDataRelPointer; //0x0008
        public int unk; //0x000C
    }
}
