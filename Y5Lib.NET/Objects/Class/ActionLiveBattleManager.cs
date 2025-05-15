using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionLiveBattleManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_LIVEBATTLEMANAGER_GET_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_DanceBattleManager_GetDancer();

        public static DanceBtlPlayer Current
        {
            get
            {
                return new DanceBtlPlayer() { Pointer = Y5Lib_DanceBattleManager_GetDancer() };
            }
        }
    }
}
