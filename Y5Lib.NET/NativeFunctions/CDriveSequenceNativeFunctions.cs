using System;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe static class CDriveSequenceNativeFunctions
    {
        public static delegate* unmanaged<IntPtr, int, void> DecideOutcome;

        public static void Init()
        {
            DecideOutcome = (delegate* unmanaged<IntPtr, int, void>)(CPP.PatternSearch("40 56 57 48 83 EC ? 48 8B 81"));
        }
    }
}
