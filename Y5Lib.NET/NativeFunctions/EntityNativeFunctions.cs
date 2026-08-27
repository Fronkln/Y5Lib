using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe static class EntityNativeFunctions
    {
        public static delegate* unmanaged<IntPtr, string, void> RegisterClass{ get; private set; }
        public static delegate* unmanaged<IntPtr, ref int, void> SetUID { get; private set; }

        internal static void Init()
        {
            RegisterClass = (delegate* unmanaged<IntPtr, string, void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 48 8B D3 48 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B 03 48 8B CB FF 50 ? 49 8D 4F"));
            SetUID = (delegate* unmanaged<IntPtr, ref int, void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 41 B8 ? ? ? ? 48 8B D6 49 8B CD"));
        }
    }
}
