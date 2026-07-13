using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct SoundCue
    {
        [FieldOffset(2)]
        public short Cuesheet;
        [FieldOffset(0)]
        public short Sound;
    }
}
