using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct LbdButton
    {
        public byte ButtonType; //0x0000
        public byte N000077FE; //0x0002
        public byte Idk; //0x0003
        public int StartPosition; //0x0004
        public int EndPosition; //0x0008
    }
}
