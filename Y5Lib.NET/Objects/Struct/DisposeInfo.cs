using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{

    // Token: 0x0200000E RID: 14
    [StructLayout(LayoutKind.Sequential)]
    public struct DisposeInfo
    {
        // Token: 0x040000CB RID: 203
        public uint N0000051D;

        // Token: 0x040000CC RID: 204
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] pad_0004;

        // Token: 0x040000CD RID: 205
        public ulong N0000051E;

        // Token: 0x040000CE RID: 206
        public uint N0000051F;

        // Token: 0x040000CF RID: 207
        public uint N000002CE;

        // Token: 0x040000D0 RID: 208
        public uint N00000520;

        // Token: 0x040000D1 RID: 209
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] pad_001C;

        // Token: 0x040000D2 RID: 210
        public uint N00000521;

        // Token: 0x040000D3 RID: 211
        public uint N000002BF;

        // Token: 0x040000D4 RID: 212
        public ChecksumString modelName;

        // Token: 0x040000D5 RID: 213
        public ulong N00000547;

        // Token: 0x040000D6 RID: 214
        public ulong N00000548;

        // Token: 0x040000D7 RID: 215
        public uint N00000549;

        // Token: 0x040000D8 RID: 216
        public uint N000002D3;

        // Token: 0x040000D9 RID: 217
        public ushort N0000054A;

        // Token: 0x040000DA RID: 218
        public short N00004547;

        // Token: 0x040000DB RID: 219
        public byte N00004545;

        // Token: 0x040000DC RID: 220
        public byte N0000454A;

        // Token: 0x040000DD RID: 221
        public NPCType FighterType;

        // Token: 0x040000DE RID: 222
        public byte N0000454B;

        // Token: 0x040000DF RID: 223
        public byte Voicer;

        // Token: 0x040000E0 RID: 224
        public byte N00004552;

        // Token: 0x040000E1 RID: 225
        public byte N00004556;

        // Token: 0x040000E2 RID: 226
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public char[] pad_006B;

        // Token: 0x040000E3 RID: 227
        public Vector4 spawnPosition;

        // Token: 0x040000E4 RID: 228
        public uint N0000054E;

        // Token: 0x040000E5 RID: 229
        public FixedString32 battleStartAnim;

        // Token: 0x040000E6 RID: 230
        public int N0000453C;

        // Token: 0x040000E7 RID: 231
        public ushort N0000453F;

        // Token: 0x040000E8 RID: 232
        public ushort N00004541;
    }
}
