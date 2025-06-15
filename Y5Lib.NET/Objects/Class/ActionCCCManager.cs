using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionCCCManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_IS_ACTIVE", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool Y5Lib_StageManager_Getter_IsActive();

        public static bool isActive
        {
            get
            {
                return Y5Lib_StageManager_Getter_IsActive();
            }
        }
    }
}
