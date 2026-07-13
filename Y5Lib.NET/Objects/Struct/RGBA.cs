using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct RGBA
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public RGBA(byte r, byte g, byte b, byte a)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }
    }
}
