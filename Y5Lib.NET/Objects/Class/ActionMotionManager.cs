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

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMOTIONMANAGER_GET_GMT_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetGMTID(string name);

        public static void LoadGMT(string name)
        {
            uint id = GetGMTID(name);

            if (id == 0)
                return;

            LoadGMT(id);
        }
    }
}
