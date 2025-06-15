using System;
using System.Reflection;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public static class ActionDanceEventManager
    {

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_DANCEEVENTMANAGER_GET_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_DanceEventManager_GetPlayer();

        public static DanceBtlPlayer Player
        {
            get
            {
                return new DanceBtlPlayer() { Pointer = Y5Lib_DanceEventManager_GetPlayer() };
            }
        }
    }
}
