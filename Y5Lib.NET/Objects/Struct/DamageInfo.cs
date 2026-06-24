using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 144)]
    public struct DamageInfo
    {
        public static DamageInfo Default
        {
            get
            {
                DamageInfo inf = new DamageInfo();

                inf.hitPos = new Vector4();
                inf.hitPos2 = new Vector4();
                inf.N000056F7 = new Vector4();
                inf.N000056F8 = 0;
                inf.attackerFID = -1;
                inf.pad_0038 = new byte[58];
                inf.hitboxLocation1 = 0;
                inf.hitEffect = 0;
                inf.hitStrength = 1;
                inf.pad_0078 = new byte[8];
                inf.damage = 0;
                inf.pad_0082 = new byte[14];

                return inf;
            }
        }

        public Vector4 hitPos; //0x0000
        public Vector4 hitPos2; //0x0010
        public Vector4 N000056F7; //0x0020
        public int N000056F8; //0x0030
        public int attackerFID; //0x0034
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 58)]
        public byte[] pad_0038; //0x0038
        public short hitboxLocation1; //0x0072
        public short hitEffect; //0x0074
        public short hitStrength; //0x0076
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] pad_0078; //0x0078
        public ushort damage; //0x0080
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public byte[] pad_0082; //0x0082
    }
}
