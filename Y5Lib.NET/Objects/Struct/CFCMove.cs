using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CFCMove
    {
        public int Unk1;
        public byte FollowupCount;
        public byte Unk2;
        public CFCMoveType Type;
    }
}
