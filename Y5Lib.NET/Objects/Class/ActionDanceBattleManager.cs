using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionDanceBattleManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_DANCEBATTLEMANAGER_GET_DANCER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_DanceBattleManager_GetDancer(int idx);

        public static DanceBtlPlayer GetDancer(int idx)
        {
            return new DanceBtlPlayer() { Pointer = Y5Lib_DanceBattleManager_GetDancer(idx) };
        }
    }
}
