using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe static class CDanceBattleDancerNativeFunctions
    {
        public static delegate* unmanaged<IntPtr, int, short, int, LbdButton*, LbdButton*, void> ButtonInputResult;

        public static void Init()
        {
            ButtonInputResult = (delegate* unmanaged<IntPtr, int, short, int, LbdButton*, LbdButton*, void>)CPP.PatternSearch("4C 8B DC 56 41 55");
        }
    }
}
