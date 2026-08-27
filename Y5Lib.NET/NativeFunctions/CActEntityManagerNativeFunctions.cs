using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe static class CActEntityManagerNativeFunctions
    {
        private static IntPtr m_entManager;

        private static delegate* unmanaged<IntPtr, IntPtr, void> m_registerEntity;

        internal static void Init()
        {
            m_entManager = Marshal.ReadIntPtr(CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8B 0D ? ? ? ? BA ? ? ? ? 48 83 C4 ? E9 ? ? ? ? 48 8B 0D ? ? ? ? BA ? ? ? ? 48 83 C4 ? E9 ? ? ? ? 2D"), 7)); 
            m_registerEntity = (delegate* unmanaged<IntPtr, IntPtr, void>)CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 48 8B 03 48 8B CB FF 50 ? 49 8D 4F"));
        }

        public static void RegisterEntity(Entity entity)
        {
            m_registerEntity(m_entManager, entity.Pointer);
        }
    }
}
