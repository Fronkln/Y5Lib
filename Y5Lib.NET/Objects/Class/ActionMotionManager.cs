using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionMotionManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_LOAD_GMT", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr LoadGMT(uint gmtID);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadPar(string path);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR_TO_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadParToID(string path, int id);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_LOAD_PAR_WITH_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadParWithID(int id, int unknown);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_GET_MOTION_PAR_ID_STATE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetMotionParIDState(int id);

        public static bool IsMotionParIDLoaded(int id) => GetMotionParIDState(id) == 4;

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_GET_GMT_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetGMTID(string name);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_LOAD_IMPORTANT_RESOURCES", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadImportantResources(bool isBattle);

        public static void LoadGMT(string name)
        {
            uint id = GetGMTID(name);

            if (id == 0)
                return;

            LoadGMT(id);
        }

    }
}
