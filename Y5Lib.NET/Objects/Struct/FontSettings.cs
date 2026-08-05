using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
    public struct FontSettings
    {
        [FieldOffset(0)]
        public int xPos; //0x0008
        [FieldOffset(4)]
        public int yPos; //0x000C
        [FieldOffset(8)]
        public short N000067F3; //0x0010
        [FieldOffset(10)]
        public short notCentered; //0x0012
        [FieldOffset(12)]
        public float N000067EB; //0x0014
        [FieldOffset(16)]
        public RGBA Color;
        [FieldOffset(20)]
        public int pad_001C; //0x001C
        [FieldOffset(24)]
        public byte N00006799; //0x0020
        [FieldOffset(25)]
        public byte N0000679F; //0x0021
        [FieldOffset(26)]
        public byte N000067A3; //0x0022
        [FieldOffset(27)]
        public byte N000067A0; //0x0023
        [FieldOffset(28)]
        public int N00006700; //0x0024
        [FieldOffset(32)]
        public int N00006800; //0x0028
        [FieldOffset(36)]
        public Vector2 scale; //0x002C
        [FieldOffset(44)]
        public int N000067EF; //0x0034
        [FieldOffset(48)]
        public int N00006795; //0x0038
        [FieldOffset(52)]
        public int N000067F0; //0x003C

        public static FontSettings Default
        {
            get
            {
                FontSettings settings = new FontSettings();
                settings.N000067F3 = 34;
                settings.notCentered = 0;
                settings.N000067EB = 65535;
                settings.Color = new RGBA(255, 255, 255, 255);
                settings.N00006799 = 255;
                settings.N0000679F = 255;
                settings.N000067A3 = 255;
                settings.N000067A0 = 0;
                settings.N00006700 = 28;
                settings.N00006800 = 14;
                settings.scale = Vector2.one;
                settings.N000067EF = 0;
                settings.N00006795 = 28;
                settings.N000067F0 = 28;
                return settings;
            }
        }
    }
}
