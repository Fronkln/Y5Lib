using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionEntityManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENTITYMANAGER_GET_ENTITY_BY_UID", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetEntityByUID(int uid);
    }
}
