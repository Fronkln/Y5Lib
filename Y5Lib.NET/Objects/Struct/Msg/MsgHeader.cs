using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 0x18)]
    public unsafe struct MsgHeader
    {
        public byte unkibunkihehehe; //0x0000
        public byte N00006916; //0x0001
        public byte N0000691A; //0x0002
        public byte groupCount; //0x0003
        public int groupsOffset; //0x0004
        public int coordsOffset; //0x0008
        public short coordsCount; //0x000C
        public short textCount; //0x000E
        public short textPointer; //0x0010
        public int padding; //0x0014


        public MsgGroupHeader* GetGroup(int index)
        {
            if (index >= groupCount)
                return null;

            fixed (int* ptr = &groupsOffset)
            {
                MsgGroupHeader* groupsStart = (MsgGroupHeader*)((long)ptr + groupsOffset);
                return &groupsStart[index];
            }
        }
    }; //Size: 0x0018
}
