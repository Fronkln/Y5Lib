using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal static unsafe class CUISStoryHDbNativeFunctions
    {
        public static delegate* unmanaged<IntPtr, int, bool, int, void> SetRow;

        public static void Init()
        {
            SetRow = (delegate* unmanaged<IntPtr, int, bool, int, void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 48 8B 74 24 ? 41 3B DC"));
        }
    }
}
