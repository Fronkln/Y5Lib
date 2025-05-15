using Microsoft.SqlServer.Server;
using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{ 
    public static class ActionHActManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTMANAGER_GET_CURRENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HActManager_GetCurrent();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTMANAGER_GET_CURRENT_PRELOADED", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HActManager_GetCurrentPreloaded();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTMANAGER_PRELOAD_HACT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_HActManager_PreloadHAct(string name, string path, int flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTMANAGER_PLAY_HACT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HActManager_PlayHAct(int hactIdx, int flags = 0);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTMANAGER_REGISTER_FIGHTER_ON_HACT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HActManager_RegisterFighterOnHAct(int hactIdx, string replaceName, int fighterIndex, int unknown = 1);



        public static HAct Current
        {
            get
            {
                return new HAct() { Pointer = Y5Lib_HActManager_GetCurrent() };
            }
        }


        public static HAct CurrentPreloaded
        {
            get
            {
                return new HAct() { Pointer = Y5Lib_HActManager_GetCurrentPreloaded() };
            }
        }

        /// <summary>
        /// Preload a HAct
        /// </summary>
        /// <returns>An index that can later be used to play the HAct.</returns>
        public static int PreloadHAct(string name, string path = "data/hact", int flags = 5)
        {
            return Y5Lib_HActManager_PreloadHAct(name, path, flags);
        }

        public static void PlayHAct(int hactIdx, int flags = 0)
        {
            Y5Lib_HActManager_PlayHAct(hactIdx, flags);
        }

        public static void RegisterFighterOnHAct(int hactIdx, string replaceName, int fighterIndex, int unknown = 1)
        {
            Y5Lib_HActManager_RegisterFighterOnHAct(hactIdx, replaceName, fighterIndex, unknown);
        }
    }
}
