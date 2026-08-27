using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe class MemoryNativeFunctions
    {
        public static delegate* unmanaged<HeapCategory, int, int, void> PushAllocCategory { get; private set; }
        public static delegate* unmanaged<void> PopAllocCategory { get; private set; }

        public static delegate* unmanaged<int, string, int, IntPtr> Alloc2 { get; private set; }

        internal static void Init()
        {
            PushAllocCategory = (delegate* unmanaged<HeapCategory, int, int, void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 90 45 33 F6 3B B7 ? ? ? ? 76 ? 48 8D 0C 76"));
            PopAllocCategory = (delegate* unmanaged<void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 48 8B 8B ? ? ? ? 48 89 8B ? ? ? ? 48 63 83 ? ? ? ? 48 8D 14 81"));
            Alloc2 = (delegate* unmanaged<int, string, int, IntPtr>)0x14003284E;
        }
    }
}
