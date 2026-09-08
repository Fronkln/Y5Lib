using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal static unsafe class PlayerNativeFunctions
    {
        public static delegate* unmanaged<int, IntPtr> GetPlayerModel { get; private set; }

        public static void Init()
        {
            GetPlayerModel = (delegate* unmanaged<int, IntPtr>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 48 8B D0 C7 44 24 ? ? ? ? ? 45 33 C9 89 7C 24"));
        }
    }
}
