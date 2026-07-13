using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct MsgGroupHeader
    {
        public int conditionsRelPointer; //0x0000
        public int propertiesRelPointer; //0x0004
        public byte conditionsCount; //0x0008
        public byte propertiesCount; //0x0009
        public byte unknown1; //0x000A
        public byte unknown2; //0x000B
        public int interactionParameters; //0x000C
    }; //Size: 0x0010
}
