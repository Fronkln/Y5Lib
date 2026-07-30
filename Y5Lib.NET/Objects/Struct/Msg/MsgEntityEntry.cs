using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 0x30)]
    public unsafe struct MsgEntityEntry
    {
	    public MsgEntityHeader *header; //0x0000
        public short N00006648; //0x0008
        public byte N00006698; //0x000A
        public byte unknownGroupIdx; //0x000B
        public byte interactionGroupIdx; //0x000C what group ID to use for msg when interacting
        public byte someForcedMsgGroupIdx; //0x000D immediately plays group msg without the player interacting when conditions are met and is in range
        public byte someForcedMsgGroupIdx2; //0x000E immediately plays group msg without the player interacting when conditions are met and is in range
        public byte someMsgGroupIdx3; //0x000F
        public int a1;
        public int a2;
        public int a3;
        public int a4;
        public int a5;
        public int a6;
        public int a7;
        public int a8;
    }; //Size: 0x0030
}
